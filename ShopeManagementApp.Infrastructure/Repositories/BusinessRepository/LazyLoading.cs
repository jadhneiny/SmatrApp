using System.Data;
using Microsoft.Extensions.Logging;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Infrastructure.Entities;

namespace ShopeManagementApp.Infrastructure.Repositories;

public partial class BusinessRepository
{
    public async Task<Addresses> Get_Addresses_By_ADDRESSES_ID(Params_Get_Addresses_By_ADDRESSES_ID i_Params_Get_Addresses_By_ADDRESSES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_ADDRESSES_ID);
            var oAddresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.QuerySingle, "UP_GET_ADDRESSES_BY_ADDRESSES_ID", _params);

            if (oAddresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_ADDRESSES_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_ADDRESSES_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            }

            return oAddresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_ADDRESSES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_ADDRESSES_ID_List(Params_Get_Addresses_By_ADDRESSES_ID_List i_Params_Get_Addresses_By_ADDRESSES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_ADDRESSES_ID_LIST", _params);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_ADDRESSES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_ADDRESSES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_ADDRESSES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID(Params_Get_Addresses_By_CUSTOMERS_ID i_Params_Get_Addresses_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_CUSTOMERS_ID);
            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_CUSTOMERS_ID", _params);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_List(Params_Get_Addresses_By_CUSTOMERS_ID_List i_Params_Get_Addresses_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_CUSTOMERS_ID_LIST", _params);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Get_Addresses_By_Properties_Response> Get_Addresses_By_Properties(Params_Get_Addresses_By_Properties i_Params_Get_Addresses_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Addresses_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_Properties);
            }

            return new()
            {
                List_Addresses = oList_Addresses,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_TENANT_ID(Params_Get_Addresses_By_TENANT_ID i_Params_Get_Addresses_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_TENANT_ID);
            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_TENANT_ID", _params);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_TENANT_ID);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_TENANT_ID);
            throw;
        }
    }

    public async Task<Admins> Get_Admins_By_ADMINS_ID(Params_Get_Admins_By_ADMINS_ID i_Params_Get_Admins_By_ADMINS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_ADMINS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_ADMINS_ID);
            var oAdmins = await _databaseContext.Execute<Admins>(Enum_Operation_Type.QuerySingle, "UP_GET_ADMINS_BY_ADMINS_ID", _params);

            if (oAdmins != null)
            {
                _logger.LogInformation("Get_Admins_By_ADMINS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_ADMINS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_ADMINS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_ADMINS_ID);
            }

            return oAdmins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_ADMINS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_ADMINS_ID_List(Params_Get_Admins_By_ADMINS_ID_List i_Params_Get_Admins_By_ADMINS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_ADMINS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_ADMINS_ID_List);
            var oList_Admins = await _databaseContext.Execute<Admins>(Enum_Operation_Type.Query, "UP_GET_ADMINS_BY_ADMINS_ID_LIST", _params);

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_ADMINS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_ADMINS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_ADMINS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_ADMINS_ID_List);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_ADMINS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID_List);
            throw;
        }
    }

    public async Task<Get_Admins_By_Properties_Response> Get_Admins_By_Properties(Params_Get_Admins_By_Properties i_Params_Get_Admins_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Admins = await _databaseContext.Execute<Admins>(Enum_Operation_Type.Query, "UP_GET_ADMINS_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Admins_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_Properties);
            }

            return new()
            {
                List_Admins = oList_Admins,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANT_ID(Params_Get_Admins_By_TENANT_ID i_Params_Get_Admins_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANT_ID);
            var oList_Admins = await _databaseContext.Execute<Admins>(Enum_Operation_Type.Query, "UP_GET_ADMINS_BY_TENANT_ID", _params);

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANT_ID);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID(Params_Get_Admins_By_TENANTS_ID i_Params_Get_Admins_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANTS_ID);
            var oList_Admins = await _databaseContext.Execute<Admins>(Enum_Operation_Type.Query, "UP_GET_ADMINS_BY_TENANTS_ID", _params);

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANTS_ID);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID_List(Params_Get_Admins_By_TENANTS_ID_List i_Params_Get_Admins_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANTS_ID_List);
            var oList_Admins = await _databaseContext.Execute<Admins>(Enum_Operation_Type.Query, "UP_GET_ADMINS_BY_TENANTS_ID_LIST", _params);

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANTS_ID_List);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Customers> Get_Customers_By_CUSTOMERS_ID(Params_Get_Customers_By_CUSTOMERS_ID i_Params_Get_Customers_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_CUSTOMERS_ID);
            var oCustomers = await _databaseContext.Execute<Customers>(Enum_Operation_Type.QuerySingle, "UP_GET_CUSTOMERS_BY_CUSTOMERS_ID", _params);

            if (oCustomers != null)
            {
                _logger.LogInformation("Get_Customers_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            }

            return oCustomers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_CUSTOMERS_ID_List(Params_Get_Customers_By_CUSTOMERS_ID_List i_Params_Get_Customers_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            var oList_Customers = await _databaseContext.Execute<Customers>(Enum_Operation_Type.Query, "UP_GET_CUSTOMERS_BY_CUSTOMERS_ID_LIST", _params);

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Get_Customers_By_Properties_Response> Get_Customers_By_Properties(Params_Get_Customers_By_Properties i_Params_Get_Customers_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Customers = await _databaseContext.Execute<Customers>(Enum_Operation_Type.Query, "UP_GET_CUSTOMERS_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Customers_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_Properties);
            }

            return new()
            {
                List_Customers = oList_Customers,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANT_ID(Params_Get_Customers_By_TENANT_ID i_Params_Get_Customers_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANT_ID);
            var oList_Customers = await _databaseContext.Execute<Customers>(Enum_Operation_Type.Query, "UP_GET_CUSTOMERS_BY_TENANT_ID", _params);

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANT_ID);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID(Params_Get_Customers_By_TENANTS_ID i_Params_Get_Customers_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANTS_ID);
            var oList_Customers = await _databaseContext.Execute<Customers>(Enum_Operation_Type.Query, "UP_GET_CUSTOMERS_BY_TENANTS_ID", _params);

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANTS_ID);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID_List(Params_Get_Customers_By_TENANTS_ID_List i_Params_Get_Customers_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANTS_ID_List);
            var oList_Customers = await _databaseContext.Execute<Customers>(Enum_Operation_Type.Query, "UP_GET_CUSTOMERS_BY_TENANTS_ID_LIST", _params);

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANTS_ID_List);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Order_details> Get_Order_details_By_ORDER_DETAILS_ID(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            var oOrder_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.QuerySingle, "UP_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID", _params);

            if (oOrder_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            }

            return oOrder_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDER_DETAILS_ID_List(Params_Get_Order_details_By_ORDER_DETAILS_ID_List i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_LIST", _params);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDER_DETAILS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDER_DETAILS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDER_DETAILS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID(Params_Get_Order_details_By_ORDERS_ID i_Params_Get_Order_details_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDERS_ID);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_ORDERS_ID", _params);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDERS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID_List(Params_Get_Order_details_By_ORDERS_ID_List i_Params_Get_Order_details_By_ORDERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDERS_ID_List);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_ORDERS_ID_LIST", _params);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID(Params_Get_Order_details_By_PRODUCTS_ID i_Params_Get_Order_details_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_PRODUCTS_ID);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_PRODUCTS_ID", _params);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID_List(Params_Get_Order_details_By_PRODUCTS_ID_List i_Params_Get_Order_details_By_PRODUCTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_PRODUCTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_PRODUCTS_ID_LIST", _params);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_PRODUCTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_PRODUCTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_PRODUCTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Order_details_By_Properties_Response> Get_Order_details_By_Properties(Params_Get_Order_details_By_Properties i_Params_Get_Order_details_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Order_details_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_Properties);
            }

            return new()
            {
                List_Order_details = oList_Order_details,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANT_ID(Params_Get_Order_details_By_TENANT_ID i_Params_Get_Order_details_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANT_ID);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_TENANT_ID", _params);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANT_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID(Params_Get_Order_details_By_TENANTS_ID i_Params_Get_Order_details_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANTS_ID);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_TENANTS_ID", _params);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANTS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID_List(Params_Get_Order_details_By_TENANTS_ID_List i_Params_Get_Order_details_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANTS_ID_List);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_TENANTS_ID_LIST", _params);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID(Params_Get_Orders_By_CUSTOMERS_ID i_Params_Get_Orders_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_CUSTOMERS_ID);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_CUSTOMERS_ID", _params);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID_List(Params_Get_Orders_By_CUSTOMERS_ID_List i_Params_Get_Orders_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_CUSTOMERS_ID_LIST", _params);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Orders> Get_Orders_By_ORDERS_ID(Params_Get_Orders_By_ORDERS_ID i_Params_Get_Orders_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_ORDERS_ID);
            var oOrders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.QuerySingle, "UP_GET_ORDERS_BY_ORDERS_ID", _params);

            if (oOrders != null)
            {
                _logger.LogInformation("Get_Orders_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_ORDERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_ORDERS_ID);
            }

            return oOrders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_ORDERS_ID_List(Params_Get_Orders_By_ORDERS_ID_List i_Params_Get_Orders_By_ORDERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_ORDERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_ORDERS_ID_List);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_ORDERS_ID_LIST", _params);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_ORDERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_ORDERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_ORDERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_ORDERS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_ORDERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID(Params_Get_Orders_By_PROMO_CODES_ID i_Params_Get_Orders_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_PROMO_CODES_ID);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_PROMO_CODES_ID", _params);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_PROMO_CODES_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_PROMO_CODES_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID_List(Params_Get_Orders_By_PROMO_CODES_ID_List i_Params_Get_Orders_By_PROMO_CODES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_PROMO_CODES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_PROMO_CODES_ID_LIST", _params);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_PROMO_CODES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_PROMO_CODES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_PROMO_CODES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            throw;
        }
    }

    public async Task<Get_Orders_By_Properties_Response> Get_Orders_By_Properties(Params_Get_Orders_By_Properties i_Params_Get_Orders_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Orders_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_Properties);
            }

            return new()
            {
                List_Orders = oList_Orders,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANT_ID(Params_Get_Orders_By_TENANT_ID i_Params_Get_Orders_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANT_ID);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_TENANT_ID", _params);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANT_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID(Params_Get_Orders_By_TENANTS_ID i_Params_Get_Orders_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANTS_ID);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_TENANTS_ID", _params);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANTS_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID_List(Params_Get_Orders_By_TENANTS_ID_List i_Params_Get_Orders_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANTS_ID_List);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_TENANTS_ID_LIST", _params);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANTS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Products> Get_Products_By_PRODUCTS_ID(Params_Get_Products_By_PRODUCTS_ID i_Params_Get_Products_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_PRODUCTS_ID);
            var oProducts = await _databaseContext.Execute<Products>(Enum_Operation_Type.QuerySingle, "UP_GET_PRODUCTS_BY_PRODUCTS_ID", _params);

            if (oProducts != null)
            {
                _logger.LogInformation("Get_Products_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_PRODUCTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_PRODUCTS_ID);
            }

            return oProducts;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_PRODUCTS_ID_List(Params_Get_Products_By_PRODUCTS_ID_List i_Params_Get_Products_By_PRODUCTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_PRODUCTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_PRODUCTS_ID_List);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_PRODUCTS_ID_LIST", _params);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_PRODUCTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_PRODUCTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_PRODUCTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Products_By_Properties_Response> Get_Products_By_Properties(Params_Get_Products_By_Properties i_Params_Get_Products_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Products_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_Properties);
            }

            return new()
            {
                List_Products = oList_Products,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID(Params_Get_Products_By_SHOPS_ID i_Params_Get_Products_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_SHOPS_ID);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_SHOPS_ID", _params);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_SHOPS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_SHOPS_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID_List(Params_Get_Products_By_SHOPS_ID_List i_Params_Get_Products_By_SHOPS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_SHOPS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_SHOPS_ID_List);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_SHOPS_ID_LIST", _params);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_SHOPS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_SHOPS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_SHOPS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_SHOPS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_SHOPS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANT_ID(Params_Get_Products_By_TENANT_ID i_Params_Get_Products_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANT_ID);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_TENANT_ID", _params);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANT_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID(Params_Get_Products_By_TENANTS_ID i_Params_Get_Products_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANTS_ID);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_TENANTS_ID", _params);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANTS_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID_List(Params_Get_Products_By_TENANTS_ID_List i_Params_Get_Products_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANTS_ID_List);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_TENANTS_ID_LIST", _params);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANTS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Promo_codes> Get_Promo_codes_By_PROMO_CODES_ID(Params_Get_Promo_codes_By_PROMO_CODES_ID i_Params_Get_Promo_codes_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            var oPromo_codes = await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.QuerySingle, "UP_GET_PROMO_CODES_BY_PROMO_CODES_ID", _params);

            if (oPromo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_PROMO_CODES_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_PROMO_CODES_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            }

            return oPromo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_PROMO_CODES_ID_List(Params_Get_Promo_codes_By_PROMO_CODES_ID_List i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_PROMO_CODES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            var oList_Promo_codes = await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Query, "UP_GET_PROMO_CODES_BY_PROMO_CODES_ID_LIST", _params);

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_PROMO_CODES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_PROMO_CODES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_PROMO_CODES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            throw;
        }
    }

    public async Task<Get_Promo_codes_By_Properties_Response> Get_Promo_codes_By_Properties(Params_Get_Promo_codes_By_Properties i_Params_Get_Promo_codes_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Promo_codes = await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Query, "UP_GET_PROMO_CODES_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Promo_codes_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_Properties);
            }

            return new()
            {
                List_Promo_codes = oList_Promo_codes,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANT_ID(Params_Get_Promo_codes_By_TENANT_ID i_Params_Get_Promo_codes_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANT_ID);
            var oList_Promo_codes = await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Query, "UP_GET_PROMO_CODES_BY_TENANT_ID", _params);

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANT_ID);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANTS_ID(Params_Get_Promo_codes_By_TENANTS_ID i_Params_Get_Promo_codes_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANTS_ID);
            var oList_Promo_codes = await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Query, "UP_GET_PROMO_CODES_BY_TENANTS_ID", _params);

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANTS_ID_List(Params_Get_Promo_codes_By_TENANTS_ID_List i_Params_Get_Promo_codes_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            var oList_Promo_codes = await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Query, "UP_GET_PROMO_CODES_BY_TENANTS_ID_LIST", _params);

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Setup_By_Properties_Response> Get_Setup_By_Properties(Params_Get_Setup_By_Properties i_Params_Get_Setup_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int64, direction: ParameterDirection.Output);

            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<long>("TOTAL_COUNT");

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_Properties);
            }

            return new()
            {
                List_Setup = oList_Setup,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_SETUP_CATEGORY_ID", _params);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST", _params);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            throw;
        }
    }

    public async Task<Setup> Get_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            var oSetup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.QuerySingle, "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);

            if (oSetup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            }

            return oSetup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            throw;
        }
    }

    public async Task<Setup> Get_Setup_By_SETUP_ID(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_ID);
            var oSetup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.QuerySingle, "UP_GET_SETUP_BY_SETUP_ID", _params);

            if (oSetup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_ID);
            }

            return oSetup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_ID_List(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_ID_List);
            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_SETUP_ID_LIST", _params);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_ID_List);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_TENANT_ID(Params_Get_Setup_By_TENANT_ID i_Params_Get_Setup_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_TENANT_ID);
            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_TENANT_ID", _params);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_TENANT_ID);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_TENANT_ID);
            throw;
        }
    }

    public async Task<Get_Setup_category_By_Properties_Response> Get_Setup_category_By_Properties(Params_Get_Setup_category_By_Properties i_Params_Get_Setup_category_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_category_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_category_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Setup_category = await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Query, "UP_GET_SETUP_CATEGORY_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Setup_category != null)
            {
                _logger.LogInformation("Get_Setup_category_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_category_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_Properties);
            }

            return new()
            {
                List_Setup_category = oList_Setup_category,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_category_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_Properties);
            throw;
        }
    }

    public async Task<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_category_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
            var oSetup_category = await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.QuerySingle, "UP_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID", _params);

            if (oSetup_category != null)
            {
                _logger.LogInformation("Get_Setup_category_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
            }

            return oSetup_category;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_category_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup_category>> Get_Setup_category_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_category_By_SETUP_CATEGORY_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
            var oList_Setup_category = await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Query, "UP_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID_LIST", _params);

            if (oList_Setup_category != null)
            {
                _logger.LogInformation("Get_Setup_category_By_SETUP_CATEGORY_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_SETUP_CATEGORY_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
            }

            return oList_Setup_category;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_category_By_SETUP_CATEGORY_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Setup_category>> Get_Setup_category_By_TENANT_ID(Params_Get_Setup_category_By_TENANT_ID i_Params_Get_Setup_category_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_category_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_category_By_TENANT_ID);
            var oList_Setup_category = await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Query, "UP_GET_SETUP_CATEGORY_BY_TENANT_ID", _params);

            if (oList_Setup_category != null)
            {
                _logger.LogInformation("Get_Setup_category_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_category_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_TENANT_ID);
            }

            return oList_Setup_category;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_category_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_TENANT_ID);
            throw;
        }
    }

    public async Task<Get_Shops_By_Properties_Response> Get_Shops_By_Properties(Params_Get_Shops_By_Properties i_Params_Get_Shops_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Shops_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_Properties);
            }

            return new()
            {
                List_Shops = oList_Shops,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_Properties);
            throw;
        }
    }

    public async Task<Shops> Get_Shops_By_SHOPS_ID(Params_Get_Shops_By_SHOPS_ID i_Params_Get_Shops_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_SHOPS_ID);
            var oShops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.QuerySingle, "UP_GET_SHOPS_BY_SHOPS_ID", _params);

            if (oShops != null)
            {
                _logger.LogInformation("Get_Shops_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_SHOPS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_SHOPS_ID);
            }

            return oShops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_SHOPS_ID_List(Params_Get_Shops_By_SHOPS_ID_List i_Params_Get_Shops_By_SHOPS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_SHOPS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_SHOPS_ID_List);
            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_SHOPS_ID_LIST", _params);

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_SHOPS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_SHOPS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_SHOPS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_SHOPS_ID_List);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_SHOPS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANT_ID(Params_Get_Shops_By_TENANT_ID i_Params_Get_Shops_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANT_ID);
            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_TENANT_ID", _params);

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANT_ID);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID(Params_Get_Shops_By_TENANTS_ID i_Params_Get_Shops_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANTS_ID);
            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_TENANTS_ID", _params);

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANTS_ID);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID_List(Params_Get_Shops_By_TENANTS_ID_List i_Params_Get_Shops_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANTS_ID_List);
            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_TENANTS_ID_LIST", _params);

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANTS_ID_List);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Tenant>> Get_Tenant_By_IS_DELETED(Params_Get_Tenant_By_IS_DELETED i_Params_Get_Tenant_By_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenant_By_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenant_By_IS_DELETED);
            var oList_Tenant = await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Query, "UP_GET_TENANT_BY_IS_DELETED", _params);

            if (oList_Tenant != null)
            {
                _logger.LogInformation("Get_Tenant_By_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenant_By_IS_DELETED);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_IS_DELETED);
            }

            return oList_Tenant;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenant_By_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_IS_DELETED);
            throw;
        }
    }

    public async Task<Get_Tenant_By_Properties_Response> Get_Tenant_By_Properties(Params_Get_Tenant_By_Properties i_Params_Get_Tenant_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenant_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenant_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Tenant = await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Query, "UP_GET_TENANT_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Tenant != null)
            {
                _logger.LogInformation("Get_Tenant_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Tenant_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_Properties);
            }

            return new()
            {
                List_Tenant = oList_Tenant,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenant_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_Properties);
            throw;
        }
    }

    public async Task<Tenant> Get_Tenant_By_TENANT_ID(Params_Get_Tenant_By_TENANT_ID i_Params_Get_Tenant_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenant_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenant_By_TENANT_ID);
            var oTenant = await _databaseContext.Execute<Tenant>(Enum_Operation_Type.QuerySingle, "UP_GET_TENANT_BY_TENANT_ID", _params);

            if (oTenant != null)
            {
                _logger.LogInformation("Get_Tenant_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenant_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_TENANT_ID);
            }

            return oTenant;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenant_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Tenant>> Get_Tenant_By_TENANT_ID_List(Params_Get_Tenant_By_TENANT_ID_List i_Params_Get_Tenant_By_TENANT_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenant_By_TENANT_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_TENANT_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenant_By_TENANT_ID_List);
            var oList_Tenant = await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Query, "UP_GET_TENANT_BY_TENANT_ID_LIST", _params);

            if (oList_Tenant != null)
            {
                _logger.LogInformation("Get_Tenant_By_TENANT_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenant_By_TENANT_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_TENANT_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_TENANT_ID_List);
            }

            return oList_Tenant;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenant_By_TENANT_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_TENANT_ID_List);
            throw;
        }
    }

    public async Task<Get_Tenants_By_Properties_Response> Get_Tenants_By_Properties(Params_Get_Tenants_By_Properties i_Params_Get_Tenants_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenants_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenants_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Tenants = await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Query, "UP_GET_TENANTS_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Tenants != null)
            {
                _logger.LogInformation("Get_Tenants_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Tenants_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_Properties);
            }

            return new()
            {
                List_Tenants = oList_Tenants,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenants_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Tenants>> Get_Tenants_By_TENANT_ID(Params_Get_Tenants_By_TENANT_ID i_Params_Get_Tenants_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenants_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenants_By_TENANT_ID);
            var oList_Tenants = await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Query, "UP_GET_TENANTS_BY_TENANT_ID", _params);

            if (oList_Tenants != null)
            {
                _logger.LogInformation("Get_Tenants_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenants_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_TENANT_ID);
            }

            return oList_Tenants;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenants_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANT_ID);
            throw;
        }
    }

    public async Task<Tenants> Get_Tenants_By_TENANTS_ID(Params_Get_Tenants_By_TENANTS_ID i_Params_Get_Tenants_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenants_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenants_By_TENANTS_ID);
            var oTenants = await _databaseContext.Execute<Tenants>(Enum_Operation_Type.QuerySingle, "UP_GET_TENANTS_BY_TENANTS_ID", _params);

            if (oTenants != null)
            {
                _logger.LogInformation("Get_Tenants_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenants_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_TENANTS_ID);
            }

            return oTenants;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenants_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Tenants>> Get_Tenants_By_TENANTS_ID_List(Params_Get_Tenants_By_TENANTS_ID_List i_Params_Get_Tenants_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenants_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenants_By_TENANTS_ID_List);
            var oList_Tenants = await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Query, "UP_GET_TENANTS_BY_TENANTS_ID_LIST", _params);

            if (oList_Tenants != null)
            {
                _logger.LogInformation("Get_Tenants_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenants_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_TENANTS_ID_List);
            }

            return oList_Tenants;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenants_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<User> Get_User_By_EMAIL_TENANT_ID(Params_Get_User_By_EMAIL_TENANT_ID i_Params_Get_User_By_EMAIL_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_EMAIL_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_EMAIL_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_EMAIL_TENANT_ID);
            var oUser = await _databaseContext.Execute<User>(Enum_Operation_Type.QuerySingle, "UP_GET_USER_BY_EMAIL_TENANT_ID", _params);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_EMAIL_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_EMAIL_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_EMAIL_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            throw;
        }
    }

    public async Task<Get_User_By_Properties_Response> Get_User_By_Properties(Params_Get_User_By_Properties i_Params_Get_User_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int64, direction: ParameterDirection.Output);

            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_PROPERTIES", _params);
            var oTotalCount = _params.Get<long>("TOTAL_COUNT");

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_User_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_User_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_Properties);
            }

            return new()
            {
                List_User = oList_User,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_TENANT_ID(Params_Get_User_By_TENANT_ID i_Params_Get_User_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_TENANT_ID);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_TENANT_ID", _params);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_TENANT_ID);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_TENANT_ID_IS_DELETED(Params_Get_User_By_TENANT_ID_IS_DELETED i_Params_Get_User_By_TENANT_ID_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_TENANT_ID_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_TENANT_ID_IS_DELETED", _params);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_TENANT_ID_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            }
            else
            {
                _logger.LogWarning("Get_User_By_TENANT_ID_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_TENANT_ID_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            throw;
        }
    }

    public async Task<User> Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_ID);
            var oUser = await _databaseContext.Execute<User>(Enum_Operation_Type.QuerySingle, "UP_GET_USER_BY_USER_ID", _params);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_USER_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_ID_List);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_USER_ID_LIST", _params);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_ID_List);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_TYPE_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_USER_TYPE_SETUP_ID", _params);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_TYPE_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_TYPE_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_TYPE_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID_List(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_TYPE_SETUP_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_USER_TYPE_SETUP_ID_LIST", _params);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_TYPE_SETUP_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_TYPE_SETUP_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_TYPE_SETUP_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            throw;
        }
    }

    public async Task<User> Get_User_By_USERNAME_TENANT_ID(Params_Get_User_By_USERNAME_TENANT_ID i_Params_Get_User_By_USERNAME_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USERNAME_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USERNAME_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USERNAME_TENANT_ID);
            var oUser = await _databaseContext.Execute<User>(Enum_Operation_Type.QuerySingle, "UP_GET_USER_BY_USERNAME_TENANT_ID", _params);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_USERNAME_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USERNAME_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USERNAME_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            throw;
        }
    }
}
