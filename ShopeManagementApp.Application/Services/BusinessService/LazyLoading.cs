using Microsoft.Extensions.Logging;
using ShopeManagementApp.Domain.Entities;

namespace ShopeManagementApp.Application.Services;

public partial class BusinessService
{
    public async Task<Addresses> Get_Addresses_By_ADDRESSES_ID(Params_Get_Addresses_By_ADDRESSES_ID i_Params_Get_Addresses_By_ADDRESSES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);

            Addresses oAddresses = null;

            oAddresses = await _businessRepository.Get_Addresses_By_ADDRESSES_ID(i_Params_Get_Addresses_By_ADDRESSES_ID);

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

            IEnumerable<Addresses> oList_Addresses = null;

            oList_Addresses = await _businessRepository.Get_Addresses_By_ADDRESSES_ID_List(i_Params_Get_Addresses_By_ADDRESSES_ID_List);

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

            IEnumerable<Addresses> oList_Addresses = null;

            oList_Addresses = await _businessRepository.Get_Addresses_By_CUSTOMERS_ID(i_Params_Get_Addresses_By_CUSTOMERS_ID);

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

            IEnumerable<Addresses> oList_Addresses = null;

            oList_Addresses = await _businessRepository.Get_Addresses_By_CUSTOMERS_ID_List(i_Params_Get_Addresses_By_CUSTOMERS_ID_List);

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

            Get_Addresses_By_Properties_Response oGet_Addresses_By_Properties_Response = null;

            if (i_Params_Get_Addresses_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Addresses_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Addresses_By_Properties.OFFSET == null || i_Params_Get_Addresses_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Addresses_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Addresses_By_Properties.FETCH_NEXT == null || i_Params_Get_Addresses_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Addresses_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Addresses_By_Properties.IS_EAGER_LOAD = false;

            oGet_Addresses_By_Properties_Response = await _businessRepository.Get_Addresses_By_Properties(i_Params_Get_Addresses_By_Properties);

            if (oGet_Addresses_By_Properties_Response != null && oGet_Addresses_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Addresses_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Addresses_By_Properties, oGet_Addresses_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_Properties);
            }

            return oGet_Addresses_By_Properties_Response;
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

            IEnumerable<Addresses> oList_Addresses = null;

            oList_Addresses = await _businessRepository.Get_Addresses_By_TENANT_ID(i_Params_Get_Addresses_By_TENANT_ID);

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

            Admins oAdmins = null;

            oAdmins = await _businessRepository.Get_Admins_By_ADMINS_ID(i_Params_Get_Admins_By_ADMINS_ID);

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

            IEnumerable<Admins> oList_Admins = null;

            oList_Admins = await _businessRepository.Get_Admins_By_ADMINS_ID_List(i_Params_Get_Admins_By_ADMINS_ID_List);

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

            Get_Admins_By_Properties_Response oGet_Admins_By_Properties_Response = null;

            if (i_Params_Get_Admins_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Admins_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Admins_By_Properties.OFFSET == null || i_Params_Get_Admins_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Admins_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Admins_By_Properties.FETCH_NEXT == null || i_Params_Get_Admins_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Admins_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Admins_By_Properties.IS_EAGER_LOAD = false;

            oGet_Admins_By_Properties_Response = await _businessRepository.Get_Admins_By_Properties(i_Params_Get_Admins_By_Properties);

            if (oGet_Admins_By_Properties_Response != null && oGet_Admins_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Admins_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Admins_By_Properties, oGet_Admins_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_Properties);
            }

            return oGet_Admins_By_Properties_Response;
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

            IEnumerable<Admins> oList_Admins = null;

            oList_Admins = await _businessRepository.Get_Admins_By_TENANT_ID(i_Params_Get_Admins_By_TENANT_ID);

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

            IEnumerable<Admins> oList_Admins = null;

            oList_Admins = await _businessRepository.Get_Admins_By_TENANTS_ID(i_Params_Get_Admins_By_TENANTS_ID);

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

            IEnumerable<Admins> oList_Admins = null;

            oList_Admins = await _businessRepository.Get_Admins_By_TENANTS_ID_List(i_Params_Get_Admins_By_TENANTS_ID_List);

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

            Customers oCustomers = null;

            oCustomers = await _businessRepository.Get_Customers_By_CUSTOMERS_ID(i_Params_Get_Customers_By_CUSTOMERS_ID);

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

            IEnumerable<Customers> oList_Customers = null;

            oList_Customers = await _businessRepository.Get_Customers_By_CUSTOMERS_ID_List(i_Params_Get_Customers_By_CUSTOMERS_ID_List);

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

            Get_Customers_By_Properties_Response oGet_Customers_By_Properties_Response = null;

            if (i_Params_Get_Customers_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Customers_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Customers_By_Properties.OFFSET == null || i_Params_Get_Customers_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Customers_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Customers_By_Properties.FETCH_NEXT == null || i_Params_Get_Customers_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Customers_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Customers_By_Properties.IS_EAGER_LOAD = false;

            oGet_Customers_By_Properties_Response = await _businessRepository.Get_Customers_By_Properties(i_Params_Get_Customers_By_Properties);

            if (oGet_Customers_By_Properties_Response != null && oGet_Customers_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Customers_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Customers_By_Properties, oGet_Customers_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_Properties);
            }

            return oGet_Customers_By_Properties_Response;
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

            IEnumerable<Customers> oList_Customers = null;

            oList_Customers = await _businessRepository.Get_Customers_By_TENANT_ID(i_Params_Get_Customers_By_TENANT_ID);

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

            IEnumerable<Customers> oList_Customers = null;

            oList_Customers = await _businessRepository.Get_Customers_By_TENANTS_ID(i_Params_Get_Customers_By_TENANTS_ID);

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

            IEnumerable<Customers> oList_Customers = null;

            oList_Customers = await _businessRepository.Get_Customers_By_TENANTS_ID_List(i_Params_Get_Customers_By_TENANTS_ID_List);

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

            Order_details oOrder_details = null;

            oOrder_details = await _businessRepository.Get_Order_details_By_ORDER_DETAILS_ID(i_Params_Get_Order_details_By_ORDER_DETAILS_ID);

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

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _businessRepository.Get_Order_details_By_ORDER_DETAILS_ID_List(i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);

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

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _businessRepository.Get_Order_details_By_ORDERS_ID(i_Params_Get_Order_details_By_ORDERS_ID);

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

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _businessRepository.Get_Order_details_By_ORDERS_ID_List(i_Params_Get_Order_details_By_ORDERS_ID_List);

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

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _businessRepository.Get_Order_details_By_PRODUCTS_ID(i_Params_Get_Order_details_By_PRODUCTS_ID);

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

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _businessRepository.Get_Order_details_By_PRODUCTS_ID_List(i_Params_Get_Order_details_By_PRODUCTS_ID_List);

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

            Get_Order_details_By_Properties_Response oGet_Order_details_By_Properties_Response = null;

            if (i_Params_Get_Order_details_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Order_details_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Order_details_By_Properties.OFFSET == null || i_Params_Get_Order_details_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Order_details_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Order_details_By_Properties.FETCH_NEXT == null || i_Params_Get_Order_details_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Order_details_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Order_details_By_Properties.IS_EAGER_LOAD = false;

            oGet_Order_details_By_Properties_Response = await _businessRepository.Get_Order_details_By_Properties(i_Params_Get_Order_details_By_Properties);

            if (oGet_Order_details_By_Properties_Response != null && oGet_Order_details_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Order_details_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Order_details_By_Properties, oGet_Order_details_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_Properties);
            }

            return oGet_Order_details_By_Properties_Response;
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

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _businessRepository.Get_Order_details_By_TENANT_ID(i_Params_Get_Order_details_By_TENANT_ID);

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

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _businessRepository.Get_Order_details_By_TENANTS_ID(i_Params_Get_Order_details_By_TENANTS_ID);

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

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _businessRepository.Get_Order_details_By_TENANTS_ID_List(i_Params_Get_Order_details_By_TENANTS_ID_List);

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

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _businessRepository.Get_Orders_By_CUSTOMERS_ID(i_Params_Get_Orders_By_CUSTOMERS_ID);

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

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _businessRepository.Get_Orders_By_CUSTOMERS_ID_List(i_Params_Get_Orders_By_CUSTOMERS_ID_List);

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

            Orders oOrders = null;

            oOrders = await _businessRepository.Get_Orders_By_ORDERS_ID(i_Params_Get_Orders_By_ORDERS_ID);

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

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _businessRepository.Get_Orders_By_ORDERS_ID_List(i_Params_Get_Orders_By_ORDERS_ID_List);

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

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _businessRepository.Get_Orders_By_PROMO_CODES_ID(i_Params_Get_Orders_By_PROMO_CODES_ID);

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

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _businessRepository.Get_Orders_By_PROMO_CODES_ID_List(i_Params_Get_Orders_By_PROMO_CODES_ID_List);

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

            Get_Orders_By_Properties_Response oGet_Orders_By_Properties_Response = null;

            if (i_Params_Get_Orders_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Orders_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Orders_By_Properties.OFFSET == null || i_Params_Get_Orders_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Orders_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Orders_By_Properties.FETCH_NEXT == null || i_Params_Get_Orders_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Orders_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Orders_By_Properties.IS_EAGER_LOAD = false;

            oGet_Orders_By_Properties_Response = await _businessRepository.Get_Orders_By_Properties(i_Params_Get_Orders_By_Properties);

            if (oGet_Orders_By_Properties_Response != null && oGet_Orders_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Orders_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Orders_By_Properties, oGet_Orders_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_Properties);
            }

            return oGet_Orders_By_Properties_Response;
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

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _businessRepository.Get_Orders_By_TENANT_ID(i_Params_Get_Orders_By_TENANT_ID);

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

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _businessRepository.Get_Orders_By_TENANTS_ID(i_Params_Get_Orders_By_TENANTS_ID);

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

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _businessRepository.Get_Orders_By_TENANTS_ID_List(i_Params_Get_Orders_By_TENANTS_ID_List);

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

            Products oProducts = null;

            oProducts = await _businessRepository.Get_Products_By_PRODUCTS_ID(i_Params_Get_Products_By_PRODUCTS_ID);

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

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _businessRepository.Get_Products_By_PRODUCTS_ID_List(i_Params_Get_Products_By_PRODUCTS_ID_List);

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

            Get_Products_By_Properties_Response oGet_Products_By_Properties_Response = null;

            if (i_Params_Get_Products_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Products_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Products_By_Properties.OFFSET == null || i_Params_Get_Products_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Products_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Products_By_Properties.FETCH_NEXT == null || i_Params_Get_Products_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Products_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Products_By_Properties.IS_EAGER_LOAD = false;

            oGet_Products_By_Properties_Response = await _businessRepository.Get_Products_By_Properties(i_Params_Get_Products_By_Properties);

            if (oGet_Products_By_Properties_Response != null && oGet_Products_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Products_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Products_By_Properties, oGet_Products_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_Properties);
            }

            return oGet_Products_By_Properties_Response;
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

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _businessRepository.Get_Products_By_SHOPS_ID(i_Params_Get_Products_By_SHOPS_ID);

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

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _businessRepository.Get_Products_By_SHOPS_ID_List(i_Params_Get_Products_By_SHOPS_ID_List);

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

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _businessRepository.Get_Products_By_TENANT_ID(i_Params_Get_Products_By_TENANT_ID);

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

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _businessRepository.Get_Products_By_TENANTS_ID(i_Params_Get_Products_By_TENANTS_ID);

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

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _businessRepository.Get_Products_By_TENANTS_ID_List(i_Params_Get_Products_By_TENANTS_ID_List);

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

            Promo_codes oPromo_codes = null;

            oPromo_codes = await _businessRepository.Get_Promo_codes_By_PROMO_CODES_ID(i_Params_Get_Promo_codes_By_PROMO_CODES_ID);

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

            IEnumerable<Promo_codes> oList_Promo_codes = null;

            oList_Promo_codes = await _businessRepository.Get_Promo_codes_By_PROMO_CODES_ID_List(i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);

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

            Get_Promo_codes_By_Properties_Response oGet_Promo_codes_By_Properties_Response = null;

            if (i_Params_Get_Promo_codes_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Promo_codes_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Promo_codes_By_Properties.OFFSET == null || i_Params_Get_Promo_codes_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Promo_codes_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Promo_codes_By_Properties.FETCH_NEXT == null || i_Params_Get_Promo_codes_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Promo_codes_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Promo_codes_By_Properties.IS_EAGER_LOAD = false;

            oGet_Promo_codes_By_Properties_Response = await _businessRepository.Get_Promo_codes_By_Properties(i_Params_Get_Promo_codes_By_Properties);

            if (oGet_Promo_codes_By_Properties_Response != null && oGet_Promo_codes_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Promo_codes_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Promo_codes_By_Properties, oGet_Promo_codes_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_Properties);
            }

            return oGet_Promo_codes_By_Properties_Response;
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

            IEnumerable<Promo_codes> oList_Promo_codes = null;

            oList_Promo_codes = await _businessRepository.Get_Promo_codes_By_TENANT_ID(i_Params_Get_Promo_codes_By_TENANT_ID);

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

            IEnumerable<Promo_codes> oList_Promo_codes = null;

            oList_Promo_codes = await _businessRepository.Get_Promo_codes_By_TENANTS_ID(i_Params_Get_Promo_codes_By_TENANTS_ID);

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

            IEnumerable<Promo_codes> oList_Promo_codes = null;

            oList_Promo_codes = await _businessRepository.Get_Promo_codes_By_TENANTS_ID_List(i_Params_Get_Promo_codes_By_TENANTS_ID_List);

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

            Get_Setup_By_Properties_Response oGet_Setup_By_Properties_Response = null;

            if (i_Params_Get_Setup_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Setup_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Setup_By_Properties.OFFSET == null || i_Params_Get_Setup_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Setup_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Properties.FETCH_NEXT == null || i_Params_Get_Setup_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Setup_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Setup_By_Properties.IS_EAGER_LOAD = false;

            oGet_Setup_By_Properties_Response = await _businessRepository.Get_Setup_By_Properties(i_Params_Get_Setup_By_Properties);

            if (oGet_Setup_By_Properties_Response != null && oGet_Setup_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Setup_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_By_Properties, oGet_Setup_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_Properties);
            }

            return oGet_Setup_By_Properties_Response;
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

            IEnumerable<Setup> oList_Setup = null;

            oList_Setup = await _businessRepository.Get_Setup_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

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

            IEnumerable<Setup> oList_Setup = null;

            oList_Setup = await _businessRepository.Get_Setup_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

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

            Setup oSetup = null;

            oSetup = await _businessRepository.Get_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

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

            Setup oSetup = null;

            oSetup = await _businessRepository.Get_Setup_By_SETUP_ID(i_Params_Get_Setup_By_SETUP_ID);

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

            IEnumerable<Setup> oList_Setup = null;

            oList_Setup = await _businessRepository.Get_Setup_By_SETUP_ID_List(i_Params_Get_Setup_By_SETUP_ID_List);

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

            IEnumerable<Setup> oList_Setup = null;

            oList_Setup = await _businessRepository.Get_Setup_By_TENANT_ID(i_Params_Get_Setup_By_TENANT_ID);

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

            Get_Setup_category_By_Properties_Response oGet_Setup_category_By_Properties_Response = null;

            if (i_Params_Get_Setup_category_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Setup_category_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Setup_category_By_Properties.OFFSET == null || i_Params_Get_Setup_category_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Setup_category_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Setup_category_By_Properties.FETCH_NEXT == null || i_Params_Get_Setup_category_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Setup_category_By_Properties.FETCH_NEXT = 1000000;
            }

            oGet_Setup_category_By_Properties_Response = await _businessRepository.Get_Setup_category_By_Properties(i_Params_Get_Setup_category_By_Properties);

            if (oGet_Setup_category_By_Properties_Response != null && oGet_Setup_category_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Setup_category_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_category_By_Properties, oGet_Setup_category_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_Properties);
            }

            return oGet_Setup_category_By_Properties_Response;
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

            Setup_category oSetup_category = null;

            oSetup_category = await _businessRepository.Get_Setup_category_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);

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

            IEnumerable<Setup_category> oList_Setup_category = null;

            oList_Setup_category = await _businessRepository.Get_Setup_category_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);

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

            IEnumerable<Setup_category> oList_Setup_category = null;

            oList_Setup_category = await _businessRepository.Get_Setup_category_By_TENANT_ID(i_Params_Get_Setup_category_By_TENANT_ID);

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

            Get_Shops_By_Properties_Response oGet_Shops_By_Properties_Response = null;

            if (i_Params_Get_Shops_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Shops_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Shops_By_Properties.OFFSET == null || i_Params_Get_Shops_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Shops_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Shops_By_Properties.FETCH_NEXT == null || i_Params_Get_Shops_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Shops_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Shops_By_Properties.IS_EAGER_LOAD = false;

            oGet_Shops_By_Properties_Response = await _businessRepository.Get_Shops_By_Properties(i_Params_Get_Shops_By_Properties);

            if (oGet_Shops_By_Properties_Response != null && oGet_Shops_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Shops_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Shops_By_Properties, oGet_Shops_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_Properties);
            }

            return oGet_Shops_By_Properties_Response;
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

            Shops oShops = null;

            oShops = await _businessRepository.Get_Shops_By_SHOPS_ID(i_Params_Get_Shops_By_SHOPS_ID);

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

            IEnumerable<Shops> oList_Shops = null;

            oList_Shops = await _businessRepository.Get_Shops_By_SHOPS_ID_List(i_Params_Get_Shops_By_SHOPS_ID_List);

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

            IEnumerable<Shops> oList_Shops = null;

            oList_Shops = await _businessRepository.Get_Shops_By_TENANT_ID(i_Params_Get_Shops_By_TENANT_ID);

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

            IEnumerable<Shops> oList_Shops = null;

            oList_Shops = await _businessRepository.Get_Shops_By_TENANTS_ID(i_Params_Get_Shops_By_TENANTS_ID);

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

            IEnumerable<Shops> oList_Shops = null;

            oList_Shops = await _businessRepository.Get_Shops_By_TENANTS_ID_List(i_Params_Get_Shops_By_TENANTS_ID_List);

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

            IEnumerable<Tenant> oList_Tenant = null;

            oList_Tenant = await _businessRepository.Get_Tenant_By_IS_DELETED(i_Params_Get_Tenant_By_IS_DELETED);

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

            Get_Tenant_By_Properties_Response oGet_Tenant_By_Properties_Response = null;

            if (i_Params_Get_Tenant_By_Properties.OFFSET == null || i_Params_Get_Tenant_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Tenant_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Tenant_By_Properties.FETCH_NEXT == null || i_Params_Get_Tenant_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Tenant_By_Properties.FETCH_NEXT = 1000000;
            }

            oGet_Tenant_By_Properties_Response = await _businessRepository.Get_Tenant_By_Properties(i_Params_Get_Tenant_By_Properties);

            if (oGet_Tenant_By_Properties_Response != null && oGet_Tenant_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Tenant_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Tenant_By_Properties, oGet_Tenant_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_Properties);
            }

            return oGet_Tenant_By_Properties_Response;
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

            Tenant oTenant = null;

            oTenant = await _businessRepository.Get_Tenant_By_TENANT_ID(i_Params_Get_Tenant_By_TENANT_ID);

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

            IEnumerable<Tenant> oList_Tenant = null;

            oList_Tenant = await _businessRepository.Get_Tenant_By_TENANT_ID_List(i_Params_Get_Tenant_By_TENANT_ID_List);

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

            Get_Tenants_By_Properties_Response oGet_Tenants_By_Properties_Response = null;

            if (i_Params_Get_Tenants_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Tenants_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Tenants_By_Properties.OFFSET == null || i_Params_Get_Tenants_By_Properties.OFFSET < 0)
            {
                i_Params_Get_Tenants_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Tenants_By_Properties.FETCH_NEXT == null || i_Params_Get_Tenants_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_Tenants_By_Properties.FETCH_NEXT = 1000000;
            }

            oGet_Tenants_By_Properties_Response = await _businessRepository.Get_Tenants_By_Properties(i_Params_Get_Tenants_By_Properties);

            if (oGet_Tenants_By_Properties_Response != null && oGet_Tenants_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Tenants_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Tenants_By_Properties, oGet_Tenants_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_Properties);
            }

            return oGet_Tenants_By_Properties_Response;
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

            IEnumerable<Tenants> oList_Tenants = null;

            oList_Tenants = await _businessRepository.Get_Tenants_By_TENANT_ID(i_Params_Get_Tenants_By_TENANT_ID);

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

            Tenants oTenants = null;

            oTenants = await _businessRepository.Get_Tenants_By_TENANTS_ID(i_Params_Get_Tenants_By_TENANTS_ID);

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

            IEnumerable<Tenants> oList_Tenants = null;

            oList_Tenants = await _businessRepository.Get_Tenants_By_TENANTS_ID_List(i_Params_Get_Tenants_By_TENANTS_ID_List);

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

            User oUser = null;

            oUser = await _businessRepository.Get_User_By_EMAIL_TENANT_ID(i_Params_Get_User_By_EMAIL_TENANT_ID);

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

            Get_User_By_Properties_Response oGet_User_By_Properties_Response = null;

            if (i_Params_Get_User_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_User_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_User_By_Properties.OFFSET == null || i_Params_Get_User_By_Properties.OFFSET < 0)
            {
                i_Params_Get_User_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_User_By_Properties.FETCH_NEXT == null || i_Params_Get_User_By_Properties.FETCH_NEXT <= 0)
            {
                i_Params_Get_User_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_User_By_Properties.IS_EAGER_LOAD = false;

            oGet_User_By_Properties_Response = await _businessRepository.Get_User_By_Properties(i_Params_Get_User_By_Properties);

            if (oGet_User_By_Properties_Response != null && oGet_User_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_User_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_User_By_Properties, oGet_User_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_User_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_Properties);
            }

            return oGet_User_By_Properties_Response;
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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_TENANT_ID(i_Params_Get_User_By_TENANT_ID);

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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_TENANT_ID_IS_DELETED(i_Params_Get_User_By_TENANT_ID_IS_DELETED);

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

            User oUser = null;

            oUser = await _businessRepository.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID);

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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List);

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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_USER_TYPE_SETUP_ID(i_Params_Get_User_By_USER_TYPE_SETUP_ID);

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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_USER_TYPE_SETUP_ID_List(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

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

            User oUser = null;

            oUser = await _businessRepository.Get_User_By_USERNAME_TENANT_ID(i_Params_Get_User_By_USERNAME_TENANT_ID);

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
