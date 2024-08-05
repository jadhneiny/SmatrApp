using System.Data;
using Microsoft.Extensions.Logging;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Infrastructure.Entities;

namespace ShopeManagementApp.Infrastructure.Repositories;

public partial class BusinessRepository
{
    public async Task<Addresses> Get_Addresses_By_ADDRESSES_ID_Eager1To1(Params_Get_Addresses_By_ADDRESSES_ID i_Params_Get_Addresses_By_ADDRESSES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_ADDRESSES_ID);

            var oAddresses = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_ADDRESSES_BY_ADDRESSES_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID",
                [
                    typeof(Addresses),
                    typeof(Customers)
                ],
                Result =>
                {
                    if (Result[0] is Addresses _Addresses)
                    {
                        if (Result[1] is Customers _Customers && _Addresses.CUSTOMERS_ID != null)
                        {
                            _Addresses.Customers = _Customers;
                        }
                        return _Addresses;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oAddresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_ADDRESSES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_ADDRESSES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            }

            return oAddresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_ADDRESSES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_ADDRESSES_ID_List_Eager1To1(Params_Get_Addresses_By_ADDRESSES_ID_List i_Params_Get_Addresses_By_ADDRESSES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_ADDRESSES_ID_List);

            var oList_Addresses = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADDRESSES_BY_ADDRESSES_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID",
                [
                    typeof(Addresses),
                    typeof(Customers)
                ],
                Result =>
                {
                    if (Result[0] is Addresses _Addresses)
                    {
                        if (Result[1] is Customers _Customers && _Addresses.CUSTOMERS_ID != null)
                        {
                            _Addresses.Customers = _Customers;
                        }
                        return _Addresses;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_ADDRESSES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_ADDRESSES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_ADDRESSES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_Eager1To1(Params_Get_Addresses_By_CUSTOMERS_ID i_Params_Get_Addresses_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_CUSTOMERS_ID);

            var oList_Addresses = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADDRESSES_BY_CUSTOMERS_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID",
                [
                    typeof(Addresses),
                    typeof(Customers)
                ],
                Result =>
                {
                    if (Result[0] is Addresses _Addresses)
                    {
                        if (Result[1] is Customers _Customers && _Addresses.CUSTOMERS_ID != null)
                        {
                            _Addresses.Customers = _Customers;
                        }
                        return _Addresses;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1(Params_Get_Addresses_By_CUSTOMERS_ID_List i_Params_Get_Addresses_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_CUSTOMERS_ID_List);

            var oList_Addresses = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADDRESSES_BY_CUSTOMERS_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID",
                [
                    typeof(Addresses),
                    typeof(Customers)
                ],
                Result =>
                {
                    if (Result[0] is Addresses _Addresses)
                    {
                        if (Result[1] is Customers _Customers && _Addresses.CUSTOMERS_ID != null)
                        {
                            _Addresses.Customers = _Customers;
                        }
                        return _Addresses;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Get_Addresses_By_Properties_Response> Get_Addresses_By_Properties_Eager1To1(Params_Get_Addresses_By_Properties i_Params_Get_Addresses_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Addresses = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADDRESSES_BY_PROPERTIES",
                _params,
                "CUSTOMERS_ID",
                [
                    typeof(Addresses),
                    typeof(Customers)
                ],
                Result =>
                {
                    if (Result[0] is Addresses _Addresses)
                    {
                        if (Result[1] is Customers _Customers && _Addresses.CUSTOMERS_ID != null)
                        {
                            _Addresses.Customers = _Customers;
                        }
                        return _Addresses;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Addresses_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_Properties);
            }

            return new()
            {
                List_Addresses = oList_Addresses,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_TENANT_ID_Eager1To1(Params_Get_Addresses_By_TENANT_ID i_Params_Get_Addresses_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_TENANT_ID);

            var oList_Addresses = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADDRESSES_BY_TENANT_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID",
                [
                    typeof(Addresses),
                    typeof(Customers)
                ],
                Result =>
                {
                    if (Result[0] is Addresses _Addresses)
                    {
                        if (Result[1] is Customers _Customers && _Addresses.CUSTOMERS_ID != null)
                        {
                            _Addresses.Customers = _Customers;
                        }
                        return _Addresses;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_TENANT_ID);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_TENANT_ID);
            throw;
        }
    }

    public async Task<Admins> Get_Admins_By_ADMINS_ID_Eager1To1(Params_Get_Admins_By_ADMINS_ID i_Params_Get_Admins_By_ADMINS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_ADMINS_ID);

            var oAdmins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_ADMINS_BY_ADMINS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oAdmins != null)
            {
                _logger.LogInformation("Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_ADMINS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_ADMINS_ID);
            }

            return oAdmins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_ADMINS_ID_List_Eager1To1(Params_Get_Admins_By_ADMINS_ID_List i_Params_Get_Admins_By_ADMINS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_ADMINS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_ADMINS_ID_List);

            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_ADMINS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_ADMINS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_ADMINS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_ADMINS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_ADMINS_ID_List);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_ADMINS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID_List);
            throw;
        }
    }

    public async Task<Get_Admins_By_Properties_Response> Get_Admins_By_Properties_Eager1To1(Params_Get_Admins_By_Properties i_Params_Get_Admins_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_PROPERTIES",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Admins_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_Properties);
            }

            return new()
            {
                List_Admins = oList_Admins,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANT_ID_Eager1To1(Params_Get_Admins_By_TENANT_ID i_Params_Get_Admins_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANT_ID);

            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANT_ID);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID_Eager1To1(Params_Get_Admins_By_TENANTS_ID i_Params_Get_Admins_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANTS_ID);

            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANTS_ID);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID_List_Eager1To1(Params_Get_Admins_By_TENANTS_ID_List i_Params_Get_Admins_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANTS_ID_List);

            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANTS_ID_List);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Customers> Get_Customers_By_CUSTOMERS_ID_Eager1To1(Params_Get_Customers_By_CUSTOMERS_ID i_Params_Get_Customers_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_CUSTOMERS_ID);

            var oCustomers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_CUSTOMERS_BY_CUSTOMERS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oCustomers != null)
            {
                _logger.LogInformation("Get_Customers_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            }

            return oCustomers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_CUSTOMERS_ID_List_Eager1To1(Params_Get_Customers_By_CUSTOMERS_ID_List i_Params_Get_Customers_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_CUSTOMERS_ID_List);

            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_CUSTOMERS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Get_Customers_By_Properties_Response> Get_Customers_By_Properties_Eager1To1(Params_Get_Customers_By_Properties i_Params_Get_Customers_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_PROPERTIES",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Customers_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_Properties);
            }

            return new()
            {
                List_Customers = oList_Customers,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANT_ID_Eager1To1(Params_Get_Customers_By_TENANT_ID i_Params_Get_Customers_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANT_ID);

            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANT_ID);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID_Eager1To1(Params_Get_Customers_By_TENANTS_ID i_Params_Get_Customers_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANTS_ID);

            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANTS_ID);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID_List_Eager1To1(Params_Get_Customers_By_TENANTS_ID_List i_Params_Get_Customers_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANTS_ID_List);

            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANTS_ID_List);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Order_details> Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDER_DETAILS_ID);

            var oOrder_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oOrder_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            }

            return oOrder_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1(Params_Get_Order_details_By_ORDER_DETAILS_ID_List i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_LIST_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID_Eager1To1(Params_Get_Order_details_By_ORDERS_ID i_Params_Get_Order_details_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDERS_ID);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_ORDERS_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDERS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID_List_Eager1To1(Params_Get_Order_details_By_ORDERS_ID_List i_Params_Get_Order_details_By_ORDERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDERS_ID_List);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_ORDERS_ID_LIST_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID_Eager1To1(Params_Get_Order_details_By_PRODUCTS_ID i_Params_Get_Order_details_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_PRODUCTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_PRODUCTS_ID);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_PRODUCTS_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_PRODUCTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_PRODUCTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_PRODUCTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID_List_Eager1To1(Params_Get_Order_details_By_PRODUCTS_ID_List i_Params_Get_Order_details_By_PRODUCTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_PRODUCTS_ID_List);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_PRODUCTS_ID_LIST_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Order_details_By_Properties_Response> Get_Order_details_By_Properties_Eager1To1(Params_Get_Order_details_By_Properties i_Params_Get_Order_details_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_PROPERTIES",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Order_details_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_Properties);
            }

            return new()
            {
                List_Order_details = oList_Order_details,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANT_ID_Eager1To1(Params_Get_Order_details_By_TENANT_ID i_Params_Get_Order_details_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANT_ID);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANT_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID_Eager1To1(Params_Get_Order_details_By_TENANTS_ID i_Params_Get_Order_details_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANTS_ID);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANTS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID_List_Eager1To1(Params_Get_Order_details_By_TENANTS_ID_List i_Params_Get_Order_details_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANTS_ID_List);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID_Eager1To1(Params_Get_Orders_By_CUSTOMERS_ID i_Params_Get_Orders_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_CUSTOMERS_ID);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_CUSTOMERS_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID_List_Eager1To1(Params_Get_Orders_By_CUSTOMERS_ID_List i_Params_Get_Orders_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_CUSTOMERS_ID_List);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_CUSTOMERS_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Orders> Get_Orders_By_ORDERS_ID_Eager1To1(Params_Get_Orders_By_ORDERS_ID i_Params_Get_Orders_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_ORDERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_ORDERS_ID);

            var oOrders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_ORDERS_BY_ORDERS_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oOrders != null)
            {
                _logger.LogInformation("Get_Orders_By_ORDERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_ORDERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_ORDERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_ORDERS_ID);
            }

            return oOrders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_ORDERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_ORDERS_ID_List_Eager1To1(Params_Get_Orders_By_ORDERS_ID_List i_Params_Get_Orders_By_ORDERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_ORDERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_ORDERS_ID_List);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_ORDERS_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_ORDERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_ORDERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_ORDERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_ORDERS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_ORDERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID_Eager1To1(Params_Get_Orders_By_PROMO_CODES_ID i_Params_Get_Orders_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_PROMO_CODES_ID);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_PROMO_CODES_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID_List_Eager1To1(Params_Get_Orders_By_PROMO_CODES_ID_List i_Params_Get_Orders_By_PROMO_CODES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_PROMO_CODES_ID_List);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_PROMO_CODES_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            throw;
        }
    }

    public async Task<Get_Orders_By_Properties_Response> Get_Orders_By_Properties_Eager1To1(Params_Get_Orders_By_Properties i_Params_Get_Orders_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_PROPERTIES",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Orders_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_Properties);
            }

            return new()
            {
                List_Orders = oList_Orders,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANT_ID_Eager1To1(Params_Get_Orders_By_TENANT_ID i_Params_Get_Orders_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANT_ID);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANT_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID_Eager1To1(Params_Get_Orders_By_TENANTS_ID i_Params_Get_Orders_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANTS_ID);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANTS_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID_List_Eager1To1(Params_Get_Orders_By_TENANTS_ID_List i_Params_Get_Orders_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANTS_ID_List);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANTS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Products> Get_Products_By_PRODUCTS_ID_Eager1To1(Params_Get_Products_By_PRODUCTS_ID i_Params_Get_Products_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_PRODUCTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_PRODUCTS_ID);

            var oProducts = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_PRODUCTS_BY_PRODUCTS_ID_EAGER1TO1",
                _params,
                "SHOPS_ID, TENANTS_ID",
                [
                    typeof(Products),
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Products _Products)
                    {
                        if (Result[1] is Shops _Shops && _Products.SHOPS_ID != null)
                        {
                            _Products.Shops = _Shops;
                        }
                        if (Result[2] is Tenants _Tenants)
                        {
                            _Products.Tenants = _Tenants;
                        }
                        return _Products;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oProducts != null)
            {
                _logger.LogInformation("Get_Products_By_PRODUCTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_PRODUCTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_PRODUCTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_PRODUCTS_ID);
            }

            return oProducts;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_PRODUCTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_PRODUCTS_ID_List_Eager1To1(Params_Get_Products_By_PRODUCTS_ID_List i_Params_Get_Products_By_PRODUCTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_PRODUCTS_ID_List);

            var oList_Products = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PRODUCTS_BY_PRODUCTS_ID_LIST_EAGER1TO1",
                _params,
                "SHOPS_ID, TENANTS_ID",
                [
                    typeof(Products),
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Products _Products)
                    {
                        if (Result[1] is Shops _Shops && _Products.SHOPS_ID != null)
                        {
                            _Products.Shops = _Shops;
                        }
                        if (Result[2] is Tenants _Tenants)
                        {
                            _Products.Tenants = _Tenants;
                        }
                        return _Products;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Products_By_Properties_Response> Get_Products_By_Properties_Eager1To1(Params_Get_Products_By_Properties i_Params_Get_Products_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Products = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PRODUCTS_BY_PROPERTIES",
                _params,
                "SHOPS_ID, TENANTS_ID",
                [
                    typeof(Products),
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Products _Products)
                    {
                        if (Result[1] is Shops _Shops && _Products.SHOPS_ID != null)
                        {
                            _Products.Shops = _Shops;
                        }
                        if (Result[2] is Tenants _Tenants)
                        {
                            _Products.Tenants = _Tenants;
                        }
                        return _Products;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Products_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_Properties);
            }

            return new()
            {
                List_Products = oList_Products,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID_Eager1To1(Params_Get_Products_By_SHOPS_ID i_Params_Get_Products_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_SHOPS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_SHOPS_ID);

            var oList_Products = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PRODUCTS_BY_SHOPS_ID_EAGER1TO1",
                _params,
                "SHOPS_ID, TENANTS_ID",
                [
                    typeof(Products),
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Products _Products)
                    {
                        if (Result[1] is Shops _Shops && _Products.SHOPS_ID != null)
                        {
                            _Products.Shops = _Shops;
                        }
                        if (Result[2] is Tenants _Tenants)
                        {
                            _Products.Tenants = _Tenants;
                        }
                        return _Products;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_SHOPS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_SHOPS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_SHOPS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_SHOPS_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_SHOPS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID_List_Eager1To1(Params_Get_Products_By_SHOPS_ID_List i_Params_Get_Products_By_SHOPS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_SHOPS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_SHOPS_ID_List);

            var oList_Products = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PRODUCTS_BY_SHOPS_ID_LIST_EAGER1TO1",
                _params,
                "SHOPS_ID, TENANTS_ID",
                [
                    typeof(Products),
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Products _Products)
                    {
                        if (Result[1] is Shops _Shops && _Products.SHOPS_ID != null)
                        {
                            _Products.Shops = _Shops;
                        }
                        if (Result[2] is Tenants _Tenants)
                        {
                            _Products.Tenants = _Tenants;
                        }
                        return _Products;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_SHOPS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_SHOPS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_SHOPS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_SHOPS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_SHOPS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANT_ID_Eager1To1(Params_Get_Products_By_TENANT_ID i_Params_Get_Products_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANT_ID);

            var oList_Products = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PRODUCTS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "SHOPS_ID, TENANTS_ID",
                [
                    typeof(Products),
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Products _Products)
                    {
                        if (Result[1] is Shops _Shops && _Products.SHOPS_ID != null)
                        {
                            _Products.Shops = _Shops;
                        }
                        if (Result[2] is Tenants _Tenants)
                        {
                            _Products.Tenants = _Tenants;
                        }
                        return _Products;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANT_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID_Eager1To1(Params_Get_Products_By_TENANTS_ID i_Params_Get_Products_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANTS_ID);

            var oList_Products = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PRODUCTS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "SHOPS_ID, TENANTS_ID",
                [
                    typeof(Products),
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Products _Products)
                    {
                        if (Result[1] is Shops _Shops && _Products.SHOPS_ID != null)
                        {
                            _Products.Shops = _Shops;
                        }
                        if (Result[2] is Tenants _Tenants)
                        {
                            _Products.Tenants = _Tenants;
                        }
                        return _Products;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANTS_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID_List_Eager1To1(Params_Get_Products_By_TENANTS_ID_List i_Params_Get_Products_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANTS_ID_List);

            var oList_Products = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PRODUCTS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "SHOPS_ID, TENANTS_ID",
                [
                    typeof(Products),
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Products _Products)
                    {
                        if (Result[1] is Shops _Shops && _Products.SHOPS_ID != null)
                        {
                            _Products.Shops = _Shops;
                        }
                        if (Result[2] is Tenants _Tenants)
                        {
                            _Products.Tenants = _Tenants;
                        }
                        return _Products;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANTS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Promo_codes> Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1(Params_Get_Promo_codes_By_PROMO_CODES_ID i_Params_Get_Promo_codes_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_PROMO_CODES_ID);

            var oPromo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_PROMO_CODES_BY_PROMO_CODES_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oPromo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            }

            return oPromo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1(Params_Get_Promo_codes_By_PROMO_CODES_ID_List i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);

            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_PROMO_CODES_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            throw;
        }
    }

    public async Task<Get_Promo_codes_By_Properties_Response> Get_Promo_codes_By_Properties_Eager1To1(Params_Get_Promo_codes_By_Properties i_Params_Get_Promo_codes_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_PROPERTIES",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Promo_codes_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_Properties);
            }

            return new()
            {
                List_Promo_codes = oList_Promo_codes,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANT_ID_Eager1To1(Params_Get_Promo_codes_By_TENANT_ID i_Params_Get_Promo_codes_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANT_ID);

            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_TENANT_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANT_ID);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANTS_ID_Eager1To1(Params_Get_Promo_codes_By_TENANTS_ID i_Params_Get_Promo_codes_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANTS_ID);

            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANTS_ID_List_Eager1To1(Params_Get_Promo_codes_By_TENANTS_ID_List i_Params_Get_Promo_codes_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANTS_ID_List);

            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Setup_By_Properties_Response> Get_Setup_By_Properties_Eager1To1(Params_Get_Setup_By_Properties i_Params_Get_Setup_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int64, direction: ParameterDirection.Output);


            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_PROPERTIES",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<long>("TOTAL_COUNT");

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_Properties);
            }

            return new()
            {
                List_Setup = oList_Setup,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            throw;
        }
    }

    public async Task<Setup> Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            var oSetup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oSetup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            }

            return oSetup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            throw;
        }
    }

    public async Task<Setup> Get_Setup_By_SETUP_ID_Eager1To1(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_ID);

            var oSetup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_SETUP_BY_SETUP_ID_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oSetup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_ID);
            }

            return oSetup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_ID_List_Eager1To1(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_ID_List);

            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_SETUP_ID_LIST_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_ID_List);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_TENANT_ID_Eager1To1(Params_Get_Setup_By_TENANT_ID i_Params_Get_Setup_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_TENANT_ID);

            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_TENANT_ID_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_TENANT_ID);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_TENANT_ID);
            throw;
        }
    }

    public async Task<Get_Shops_By_Properties_Response> Get_Shops_By_Properties_Eager1To1(Params_Get_Shops_By_Properties i_Params_Get_Shops_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Shops = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SHOPS_BY_PROPERTIES",
                _params,
                "TENANTS_ID",
                [
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Shops _Shops)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Shops.Tenants = _Tenants;
                        }
                        return _Shops;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Shops_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_Properties);
            }

            return new()
            {
                List_Shops = oList_Shops,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_Properties);
            throw;
        }
    }

    public async Task<Shops> Get_Shops_By_SHOPS_ID_Eager1To1(Params_Get_Shops_By_SHOPS_ID i_Params_Get_Shops_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_SHOPS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_SHOPS_ID);

            var oShops = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_SHOPS_BY_SHOPS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Shops _Shops)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Shops.Tenants = _Tenants;
                        }
                        return _Shops;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oShops != null)
            {
                _logger.LogInformation("Get_Shops_By_SHOPS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_SHOPS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_SHOPS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_SHOPS_ID);
            }

            return oShops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_SHOPS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_SHOPS_ID_List_Eager1To1(Params_Get_Shops_By_SHOPS_ID_List i_Params_Get_Shops_By_SHOPS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_SHOPS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_SHOPS_ID_List);

            var oList_Shops = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SHOPS_BY_SHOPS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Shops _Shops)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Shops.Tenants = _Tenants;
                        }
                        return _Shops;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_SHOPS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_SHOPS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_SHOPS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_SHOPS_ID_List);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_SHOPS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANT_ID_Eager1To1(Params_Get_Shops_By_TENANT_ID i_Params_Get_Shops_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANT_ID);

            var oList_Shops = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SHOPS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Shops _Shops)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Shops.Tenants = _Tenants;
                        }
                        return _Shops;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANT_ID);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID_Eager1To1(Params_Get_Shops_By_TENANTS_ID i_Params_Get_Shops_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANTS_ID);

            var oList_Shops = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SHOPS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Shops _Shops)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Shops.Tenants = _Tenants;
                        }
                        return _Shops;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANTS_ID);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID_List_Eager1To1(Params_Get_Shops_By_TENANTS_ID_List i_Params_Get_Shops_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANTS_ID_List);

            var oList_Shops = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SHOPS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Shops),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Shops _Shops)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Shops.Tenants = _Tenants;
                        }
                        return _Shops;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANTS_ID_List);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<User> Get_User_By_EMAIL_TENANT_ID_Eager1To1(Params_Get_User_By_EMAIL_TENANT_ID i_Params_Get_User_By_EMAIL_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_EMAIL_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_EMAIL_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_EMAIL_TENANT_ID);

            var oUser = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_USER_BY_EMAIL_TENANT_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_EMAIL_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_EMAIL_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_EMAIL_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            throw;
        }
    }

    public async Task<Get_User_By_Properties_Response> Get_User_By_Properties_Eager1To1(Params_Get_User_By_Properties i_Params_Get_User_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int64, direction: ParameterDirection.Output);


            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_PROPERTIES",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            var oTotalCount = _params.Get<long>("TOTAL_COUNT");

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_User_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_User_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_Properties);
            }

            return new()
            {
                List_User = oList_User,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_TENANT_ID_Eager1To1(Params_Get_User_By_TENANT_ID i_Params_Get_User_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_TENANT_ID);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_TENANT_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_TENANT_ID);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_TENANT_ID_IS_DELETED_Eager1To1(Params_Get_User_By_TENANT_ID_IS_DELETED i_Params_Get_User_By_TENANT_ID_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_TENANT_ID_IS_DELETED_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_TENANT_ID_IS_DELETED);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_TENANT_ID_IS_DELETED_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_TENANT_ID_IS_DELETED_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            }
            else
            {
                _logger.LogWarning("Get_User_By_TENANT_ID_IS_DELETED_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_TENANT_ID_IS_DELETED_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            throw;
        }
    }

    public async Task<User> Get_User_By_USER_ID_Eager1To1(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_ID);

            var oUser = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_USER_BY_USER_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_USER_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_ID_List_Eager1To1(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_ID_List);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_USER_ID_LIST_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_ID_List);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID_Eager1To1(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_TYPE_SETUP_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_USER_TYPE_SETUP_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_TYPE_SETUP_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_TYPE_SETUP_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_TYPE_SETUP_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_USER_TYPE_SETUP_ID_LIST_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            throw;
        }
    }

    public async Task<User> Get_User_By_USERNAME_TENANT_ID_Eager1To1(Params_Get_User_By_USERNAME_TENANT_ID i_Params_Get_User_By_USERNAME_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USERNAME_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USERNAME_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USERNAME_TENANT_ID);

            var oUser = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_USER_BY_USERNAME_TENANT_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            );

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_USERNAME_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USERNAME_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USERNAME_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            throw;
        }
    }
}
