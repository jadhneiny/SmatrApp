using Dapper;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Common.Contracts;
using ShopeManagementApp.Infrastructure.Entities;
using ShopeManagementApp.Infrastructure.Contracts;

namespace ShopeManagementApp.Infrastructure.Data;

public partial class DatabaseContext : IDatabaseContext, IAsyncDisposable
{
    private bool _disposed;
    private SqlConnection _sqlConnection;
    private SqlTransaction _sqlTransaction;

    private readonly ILogger<DatabaseContext> _logger;
    private readonly ApplicationSettings _applicationSettings;
    private readonly string _sqlServerConnectionString;
    private readonly IUserSessionContext _userSessionContext;
    private readonly SemaphoreSlim _connectionSemaphore = new(1, 1);

    public DatabaseContext(
        ILogger<DatabaseContext> i_Logger,
        IOptions<ApplicationSettings> i_ApplicationSettings,
        IConfiguration i_Configuration,
        IUserSessionContext i_UserSessionContext
    )
    {
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
        _userSessionContext = i_UserSessionContext ?? throw new ArgumentNullException(nameof(i_UserSessionContext));
        _sqlServerConnectionString = i_Configuration.GetConnectionString("Sql_Server_Connection_String") ?? throw new InvalidOperationException("SQL Server connection string is not configured.");

        _logger.LogInformation("DatabaseContext instantiated with connection string: {ConnectionString}", MaskConnectionStringPassword(_sqlServerConnectionString));
    }

    public async Task<dynamic> Execute<TReturn>(
        Enum_Operation_Type i_Operation_Type,
        string i_Stored_Procedure,
        DynamicParameters i_DynamicParameters,
        string i_Split_On = "",
        Type[] i_List_Type = null,
        Func<object[], TReturn> i_Map = null,
        CommandType i_CommandType = CommandType.StoredProcedure
    )
    {
        try
        {
            dynamic result;

            _logger.LogInformation("Executing operation: {OperationType} with stored procedure: {StoredProcedure}", i_Operation_Type, i_Stored_Procedure);

            await EnsureConnectionOpenAsync();

            switch (i_Operation_Type)
            {
                case Enum_Operation_Type.Query:
                    result = await _sqlConnection.QueryAsync<TReturn>(
                        i_Stored_Procedure,
                        i_DynamicParameters,
                        commandType: i_CommandType,
                        transaction: _sqlTransaction,
                        commandTimeout: _applicationSettings.ApplicationConfig.DatabaseConnectionCommandTimeout
                    );
                    break;
                case Enum_Operation_Type.QueryEagerly:
                case Enum_Operation_Type.QueryEagerlySingle:
                    ArgumentNullException.ThrowIfNull(i_Map, nameof(i_Map));
                    ArgumentNullException.ThrowIfNull(i_List_Type, nameof(i_List_Type));
                    var queryResult = await _sqlConnection.QueryAsync(
                        i_Stored_Procedure,
                        i_List_Type,
                        i_Map,
                        splitOn: i_Split_On,
                        param: i_DynamicParameters,
                        commandType: i_CommandType,
                        transaction: _sqlTransaction,
                        commandTimeout: _applicationSettings.ApplicationConfig.DatabaseConnectionCommandTimeout
                    );
                    result = i_Operation_Type == Enum_Operation_Type.QueryEagerly ? queryResult : queryResult.FirstOrDefault();
                    break;
                case Enum_Operation_Type.QuerySingle:
                    result = await _sqlConnection.QuerySingleOrDefaultAsync<TReturn>(
                        i_Stored_Procedure,
                        i_DynamicParameters,
                        commandType: i_CommandType,
                        transaction: _sqlTransaction,
                        commandTimeout: _applicationSettings.ApplicationConfig.DatabaseConnectionCommandTimeout
                    );
                    break;
                case Enum_Operation_Type.Execute:
                    await _sqlConnection.ExecuteAsync(
                        i_Stored_Procedure,
                        i_DynamicParameters,
                        commandType: i_CommandType,
                        transaction: _sqlTransaction,
                        commandTimeout: _applicationSettings.ApplicationConfig.DatabaseConnectionCommandTimeout
                    );
                    result = default;
                    break;
                default:
                    _logger.LogError("Invalid operation type: {OperationType}", i_Operation_Type);
                    throw new ArgumentException("Invalid operation type.", nameof(i_Operation_Type));
            }

            _logger.LogInformation("Operation {OperationType} completed successfully with stored procedure: {StoredProcedure}", i_Operation_Type, i_Stored_Procedure);
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred executing the operation: {OperationType} with stored procedure: {StoredProcedure}. Initiating rollback.", i_Operation_Type, i_Stored_Procedure);
            await RollbackAsync();
            throw;
        }
    }

    public async Task SetContext()
    {
        _logger.LogInformation("Setting database context for session.");
        try
        {
            await EnsureConnectionOpenAsync();

            // Tenant ID context setting
            if (_userSessionContext.Tenant_ID != default)
            {
                var tenantParameters = new DynamicParameters();
                tenantParameters.Add("TENANT_ID", _userSessionContext.Tenant_ID, DbType.Int32);
                await _sqlConnection.ExecuteAsync("EXEC sp_set_session_context @key=N'TENANT_ID', @value=@TENANT_ID;", tenantParameters, _sqlTransaction);
                _logger.LogInformation("Tenant ID session context set: {TenantID}", _userSessionContext.Tenant_ID);
            }

            // RLS context setting
            var bypassRlsParameters = new DynamicParameters();
            bypassRlsParameters.Add("BYPASS_RLS", _userSessionContext.Bypass_RLS ? 1 : 0, DbType.Int32);
            await _sqlConnection.ExecuteAsync("EXEC sp_set_session_context @key=N'BYPASS_RLS', @value=@BYPASS_RLS;", bypassRlsParameters, _sqlTransaction);
            _logger.LogInformation("BYPASS_RLS session context set: {BypassRLS}", _userSessionContext.Bypass_RLS);

            _logger.LogInformation("Database context setting completed.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error setting database context.");
            throw;
        }
    }

    public async Task BeginTransactionAsync()
    {
        _logger.LogInformation("Attempting to begin a new database transaction.");
        try
        {
            await EnsureConnectionOpenAsync();
            if (_sqlTransaction == null)
            {
                _sqlTransaction = _sqlConnection.BeginTransaction();
                _logger.LogInformation("New database transaction started.");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to begin a new database transaction.");
            throw;
        }
    }

    public async Task CommitAsync()
    {
        _logger.LogInformation("Attempting to commit the current transaction.");
        try
        {
            if (_sqlTransaction != null)
            {
                await _sqlTransaction.CommitAsync();
                _logger.LogInformation("Transaction committed successfully.");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to commit the transaction.");
            throw;
        }
        finally
        {
            if (_sqlTransaction != null)
            {
                await DisposeTransactionAsync();
            }
        }
    }

    public async Task RollbackAsync()
    {
        _logger.LogInformation("Attempting to rollback the current transaction.");
        try
        {
            if (_sqlTransaction != null)
            {
                await _sqlTransaction.RollbackAsync();
                _logger.LogInformation("Transaction rolled back successfully.");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to rollback the transaction.");
            throw;
        }
        finally
        {
            if (_sqlTransaction != null)
            {
                await DisposeTransactionAsync();
            }
        }
    }

    private async Task EnsureConnectionOpenAsync()
    {
        if (_sqlConnection == null)
        {
            await _connectionSemaphore.WaitAsync();
            try
            {
                _logger.LogInformation("Creating new SQL connection.");
                _sqlConnection = new SqlConnection(_sqlServerConnectionString);

                await OpenSqlConnectionAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while ensuring the SQL connection is open.");
                throw;
            }
            finally
            {
                _connectionSemaphore.Release();
            }
        }
    }

    private async Task OpenSqlConnectionAsync()
    {
        if (_sqlConnection.State == ConnectionState.Closed || _sqlConnection.State == ConnectionState.Broken)
        {
            _logger.LogInformation("Opening SQL connection. Current state: {ConnectionState}", _sqlConnection.State);
            await _sqlConnection.OpenAsync().ConfigureAwait(false);
            _logger.LogInformation("SQL connection opened successfully.");
        }
    }

    private async Task DisposeTransactionAsync()
    {
        if (_sqlTransaction != null)
        {
            _logger.LogInformation("Disposing the current database transaction.");
            await _sqlTransaction.DisposeAsync();
            _sqlTransaction = null;
            _logger.LogInformation("Database transaction disposed.");
        }
    }

    private static string MaskConnectionStringPassword(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException("Connection string cannot be null or whitespace.", nameof(connectionString));
        }

        // Pattern to match the password in the connection string
        string pattern = @"(Password\s*=\s*)([^;]+)";
        string maskedConnectionString = Regex.Replace(connectionString, pattern, "$1********");

        return maskedConnectionString;
    }

    public async ValueTask DisposeAsync()
    {
        _logger.LogInformation("Disposing DatabaseContext.");
        if (!_disposed)
        {
            if (_sqlTransaction != null)
            {
                await DisposeTransactionAsync();
            }

            if (_sqlConnection != null)
            {
                await _sqlConnection.CloseAsync();
                await _sqlConnection.DisposeAsync();
                _sqlConnection = null;
            }

            _connectionSemaphore.Dispose();

            _disposed = true;
            _logger.LogInformation("DatabaseContext disposed.");
        }
        GC.SuppressFinalize(this);
    }
}
