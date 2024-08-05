using System.Data;
using Microsoft.Extensions.Logging;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Infrastructure.Entities;

namespace ShopeManagementApp.Infrastructure.Repositories;

public partial class BusinessRepository
{
    public async Task Delete_Addresses(Params_Delete_Addresses i_Params_Delete_Addresses)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Addresses);
            await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Execute, "UP_DELETE_ADDRESSES", _params);

            _logger.LogInformation("Delete_Addresses operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses);
            throw;
        }
    }

    public async Task Delete_Addresses_By_CUSTOMERS_ID(Params_Delete_Addresses_By_CUSTOMERS_ID i_Params_Delete_Addresses_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Addresses_By_CUSTOMERS_ID);
            await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Execute, "UP_DELETE_ADDRESSES_BY_CUSTOMERS_ID", _params);

            _logger.LogInformation("Delete_Addresses_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task Delete_Addresses_By_TENANT_ID(Params_Delete_Addresses_By_TENANT_ID i_Params_Delete_Addresses_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Addresses_By_TENANT_ID);
            await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Execute, "UP_DELETE_ADDRESSES_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Addresses_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_Addresses(Addresses i_Addresses)
    {
        var operation = i_Addresses.ADDRESSES_ID == -1 ? "Create New Addresses" : "Update Existing Addresses";

        try
        {
            _logger.LogInformation("Initiating Edit_Addresses operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Addresses);
            _params.Add("ADDRESSES_ID", i_Addresses.ADDRESSES_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Addresses.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Addresses.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Execute, "UP_EDIT_ADDRESSES", _params);

            i_Addresses.ADDRESSES_ID = _params.Get<int>("ADDRESSES_ID");
            i_Addresses.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Addresses.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Addresses operation at the repository layer completed successfully: {Operation}. Addresses ID: {ADDRESSES_ID}", operation, i_Addresses.ADDRESSES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Admins(Params_Delete_Admins i_Params_Delete_Admins)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Admins);
            await _databaseContext.Execute<Admins>(Enum_Operation_Type.Execute, "UP_DELETE_ADMINS", _params);

            _logger.LogInformation("Delete_Admins operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins);
            throw;
        }
    }

    public async Task Delete_Admins_By_TENANT_ID(Params_Delete_Admins_By_TENANT_ID i_Params_Delete_Admins_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Admins_By_TENANT_ID);
            await _databaseContext.Execute<Admins>(Enum_Operation_Type.Execute, "UP_DELETE_ADMINS_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Admins_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Admins_By_TENANTS_ID(Params_Delete_Admins_By_TENANTS_ID i_Params_Delete_Admins_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Admins_By_TENANTS_ID);
            await _databaseContext.Execute<Admins>(Enum_Operation_Type.Execute, "UP_DELETE_ADMINS_BY_TENANTS_ID", _params);

            _logger.LogInformation("Delete_Admins_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Admins(Admins i_Admins)
    {
        var operation = i_Admins.ADMINS_ID == -1 ? "Create New Admins" : "Update Existing Admins";

        try
        {
            _logger.LogInformation("Initiating Edit_Admins operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Admins);
            _params.Add("ADMINS_ID", i_Admins.ADMINS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Admins.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Admins.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Admins>(Enum_Operation_Type.Execute, "UP_EDIT_ADMINS", _params);

            i_Admins.ADMINS_ID = _params.Get<int>("ADMINS_ID");
            i_Admins.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Admins.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Admins operation at the repository layer completed successfully: {Operation}. Admins ID: {ADMINS_ID}", operation, i_Admins.ADMINS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Customers(Params_Delete_Customers i_Params_Delete_Customers)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Customers);
            await _databaseContext.Execute<Customers>(Enum_Operation_Type.Execute, "UP_DELETE_CUSTOMERS", _params);

            _logger.LogInformation("Delete_Customers operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers);
            throw;
        }
    }

    public async Task Delete_Customers_By_TENANT_ID(Params_Delete_Customers_By_TENANT_ID i_Params_Delete_Customers_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Customers_By_TENANT_ID);
            await _databaseContext.Execute<Customers>(Enum_Operation_Type.Execute, "UP_DELETE_CUSTOMERS_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Customers_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Customers_By_TENANTS_ID(Params_Delete_Customers_By_TENANTS_ID i_Params_Delete_Customers_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Customers_By_TENANTS_ID);
            await _databaseContext.Execute<Customers>(Enum_Operation_Type.Execute, "UP_DELETE_CUSTOMERS_BY_TENANTS_ID", _params);

            _logger.LogInformation("Delete_Customers_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Customers(Customers i_Customers)
    {
        var operation = i_Customers.CUSTOMERS_ID == -1 ? "Create New Customers" : "Update Existing Customers";

        try
        {
            _logger.LogInformation("Initiating Edit_Customers operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Customers);
            _params.Add("CUSTOMERS_ID", i_Customers.CUSTOMERS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Customers.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Customers.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Customers>(Enum_Operation_Type.Execute, "UP_EDIT_CUSTOMERS", _params);

            i_Customers.CUSTOMERS_ID = _params.Get<int>("CUSTOMERS_ID");
            i_Customers.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Customers.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Customers operation at the repository layer completed successfully: {Operation}. Customers ID: {CUSTOMERS_ID}", operation, i_Customers.CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Order_details(Params_Delete_Order_details i_Params_Delete_Order_details)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS", _params);

            _logger.LogInformation("Delete_Order_details operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details);
            throw;
        }
    }

    public async Task Delete_Order_details_By_ORDERS_ID(Params_Delete_Order_details_By_ORDERS_ID i_Params_Delete_Order_details_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details_By_ORDERS_ID);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS_BY_ORDERS_ID", _params);

            _logger.LogInformation("Delete_Order_details_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);
            throw;
        }
    }

    public async Task Delete_Order_details_By_PRODUCTS_ID(Params_Delete_Order_details_By_PRODUCTS_ID i_Params_Delete_Order_details_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details_By_PRODUCTS_ID);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS_BY_PRODUCTS_ID", _params);

            _logger.LogInformation("Delete_Order_details_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task Delete_Order_details_By_TENANT_ID(Params_Delete_Order_details_By_TENANT_ID i_Params_Delete_Order_details_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details_By_TENANT_ID);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Order_details_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Order_details_By_TENANTS_ID(Params_Delete_Order_details_By_TENANTS_ID i_Params_Delete_Order_details_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details_By_TENANTS_ID);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS_BY_TENANTS_ID", _params);

            _logger.LogInformation("Delete_Order_details_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Order_details(Order_details i_Order_details)
    {
        var operation = i_Order_details.ORDER_DETAILS_ID == -1 ? "Create New Order_details" : "Update Existing Order_details";

        try
        {
            _logger.LogInformation("Initiating Edit_Order_details operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Order_details);
            _params.Add("ORDER_DETAILS_ID", i_Order_details.ORDER_DETAILS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Order_details.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Order_details.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_EDIT_ORDER_DETAILS", _params);

            i_Order_details.ORDER_DETAILS_ID = _params.Get<int>("ORDER_DETAILS_ID");
            i_Order_details.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Order_details.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Order_details operation at the repository layer completed successfully: {Operation}. Order_details ID: {ORDER_DETAILS_ID}", operation, i_Order_details.ORDER_DETAILS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Orders(Params_Delete_Orders i_Params_Delete_Orders)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS", _params);

            _logger.LogInformation("Delete_Orders operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders);
            throw;
        }
    }

    public async Task Delete_Orders_By_CUSTOMERS_ID(Params_Delete_Orders_By_CUSTOMERS_ID i_Params_Delete_Orders_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders_By_CUSTOMERS_ID);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS_BY_CUSTOMERS_ID", _params);

            _logger.LogInformation("Delete_Orders_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task Delete_Orders_By_PROMO_CODES_ID(Params_Delete_Orders_By_PROMO_CODES_ID i_Params_Delete_Orders_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders_By_PROMO_CODES_ID);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS_BY_PROMO_CODES_ID", _params);

            _logger.LogInformation("Delete_Orders_By_PROMO_CODES_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task Delete_Orders_By_TENANT_ID(Params_Delete_Orders_By_TENANT_ID i_Params_Delete_Orders_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders_By_TENANT_ID);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Orders_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Orders_By_TENANTS_ID(Params_Delete_Orders_By_TENANTS_ID i_Params_Delete_Orders_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders_By_TENANTS_ID);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS_BY_TENANTS_ID", _params);

            _logger.LogInformation("Delete_Orders_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Orders(Orders i_Orders)
    {
        var operation = i_Orders.ORDERS_ID == -1 ? "Create New Orders" : "Update Existing Orders";

        try
        {
            _logger.LogInformation("Initiating Edit_Orders operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Orders);
            _params.Add("ORDERS_ID", i_Orders.ORDERS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Orders.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Orders.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_EDIT_ORDERS", _params);

            i_Orders.ORDERS_ID = _params.Get<int>("ORDERS_ID");
            i_Orders.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Orders.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Orders operation at the repository layer completed successfully: {Operation}. Orders ID: {ORDERS_ID}", operation, i_Orders.ORDERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Products(Params_Delete_Products i_Params_Delete_Products)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Products);
            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_DELETE_PRODUCTS", _params);

            _logger.LogInformation("Delete_Products operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products);
            throw;
        }
    }

    public async Task Delete_Products_By_SHOPS_ID(Params_Delete_Products_By_SHOPS_ID i_Params_Delete_Products_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Products_By_SHOPS_ID);
            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_DELETE_PRODUCTS_BY_SHOPS_ID", _params);

            _logger.LogInformation("Delete_Products_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);
            throw;
        }
    }

    public async Task Delete_Products_By_TENANT_ID(Params_Delete_Products_By_TENANT_ID i_Params_Delete_Products_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Products_By_TENANT_ID);
            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_DELETE_PRODUCTS_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Products_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Products_By_TENANTS_ID(Params_Delete_Products_By_TENANTS_ID i_Params_Delete_Products_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Products_By_TENANTS_ID);
            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_DELETE_PRODUCTS_BY_TENANTS_ID", _params);

            _logger.LogInformation("Delete_Products_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Products(Products i_Products)
    {
        var operation = i_Products.PRODUCTS_ID == -1 ? "Create New Products" : "Update Existing Products";

        try
        {
            _logger.LogInformation("Initiating Edit_Products operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Products);
            _params.Add("PRODUCTS_ID", i_Products.PRODUCTS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Products.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Products.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_EDIT_PRODUCTS", _params);

            i_Products.PRODUCTS_ID = _params.Get<int>("PRODUCTS_ID");
            i_Products.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Products.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Products operation at the repository layer completed successfully: {Operation}. Products ID: {PRODUCTS_ID}", operation, i_Products.PRODUCTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Promo_codes(Params_Delete_Promo_codes i_Params_Delete_Promo_codes)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Promo_codes);
            await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Execute, "UP_DELETE_PROMO_CODES", _params);

            _logger.LogInformation("Delete_Promo_codes operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes);
            throw;
        }
    }

    public async Task Delete_Promo_codes_By_TENANT_ID(Params_Delete_Promo_codes_By_TENANT_ID i_Params_Delete_Promo_codes_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Promo_codes_By_TENANT_ID);
            await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Execute, "UP_DELETE_PROMO_CODES_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Promo_codes_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Promo_codes_By_TENANTS_ID(Params_Delete_Promo_codes_By_TENANTS_ID i_Params_Delete_Promo_codes_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Promo_codes_By_TENANTS_ID);
            await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Execute, "UP_DELETE_PROMO_CODES_BY_TENANTS_ID", _params);

            _logger.LogInformation("Delete_Promo_codes_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Promo_codes(Promo_codes i_Promo_codes)
    {
        var operation = i_Promo_codes.PROMO_CODES_ID == -1 ? "Create New Promo_codes" : "Update Existing Promo_codes";

        try
        {
            _logger.LogInformation("Initiating Edit_Promo_codes operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Promo_codes);
            _params.Add("PROMO_CODES_ID", i_Promo_codes.PROMO_CODES_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Promo_codes.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Promo_codes.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Execute, "UP_EDIT_PROMO_CODES", _params);

            i_Promo_codes.PROMO_CODES_ID = _params.Get<int>("PROMO_CODES_ID");
            i_Promo_codes.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Promo_codes.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Promo_codes operation at the repository layer completed successfully: {Operation}. Promo_codes ID: {PROMO_CODES_ID}", operation, i_Promo_codes.PROMO_CODES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup);
            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP", _params);

            _logger.LogInformation("Delete_Setup operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup);
            throw;
        }
    }

    public async Task Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_BY_SETUP_CATEGORY_ID", _params);

            _logger.LogInformation("Delete_Setup_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
            throw;
        }
    }

    public async Task Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);

            _logger.LogInformation("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
            throw;
        }
    }

    public async Task Delete_Setup_By_TENANT_ID(Params_Delete_Setup_By_TENANT_ID i_Params_Delete_Setup_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_By_TENANT_ID);
            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Setup_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_Setup(Setup i_Setup)
    {
        var operation = i_Setup.SETUP_ID == -1 ? "Create New Setup" : "Update Existing Setup";

        try
        {
            _logger.LogInformation("Initiating Edit_Setup operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Setup);
            _params.Add("SETUP_ID", i_Setup.SETUP_ID, DbType.Int64, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Setup.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Setup.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_EDIT_SETUP", _params);

            i_Setup.SETUP_ID = _params.Get<long>("SETUP_ID");
            i_Setup.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Setup.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Setup operation at the repository layer completed successfully: {Operation}. Setup ID: {SETUP_ID}", operation, i_Setup.SETUP_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_category operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_category);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_category);
            await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_CATEGORY", _params);

            _logger.LogInformation("Delete_Setup_category operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_category);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_category operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_category);
            throw;
        }
    }

    public async Task Delete_Setup_category_By_TENANT_ID(Params_Delete_Setup_category_By_TENANT_ID i_Params_Delete_Setup_category_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_category_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_category_By_TENANT_ID);
            await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_CATEGORY_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Setup_category_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_category_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_Setup_category(Setup_category i_Setup_category)
    {
        var operation = i_Setup_category.SETUP_CATEGORY_ID == -1 ? "Create New Setup_category" : "Update Existing Setup_category";

        try
        {
            _logger.LogInformation("Initiating Edit_Setup_category operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Setup_category);
            _params.Add("SETUP_CATEGORY_ID", i_Setup_category.SETUP_CATEGORY_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Setup_category.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Setup_category.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Execute, "UP_EDIT_SETUP_CATEGORY", _params);

            i_Setup_category.SETUP_CATEGORY_ID = _params.Get<int>("SETUP_CATEGORY_ID");
            i_Setup_category.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Setup_category.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Setup_category operation at the repository layer completed successfully: {Operation}. Setup_category ID: {SETUP_CATEGORY_ID}", operation, i_Setup_category.SETUP_CATEGORY_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Shops(Params_Delete_Shops i_Params_Delete_Shops)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Shops);
            await _databaseContext.Execute<Shops>(Enum_Operation_Type.Execute, "UP_DELETE_SHOPS", _params);

            _logger.LogInformation("Delete_Shops operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops);
            throw;
        }
    }

    public async Task Delete_Shops_By_TENANT_ID(Params_Delete_Shops_By_TENANT_ID i_Params_Delete_Shops_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Shops_By_TENANT_ID);
            await _databaseContext.Execute<Shops>(Enum_Operation_Type.Execute, "UP_DELETE_SHOPS_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Shops_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Shops_By_TENANTS_ID(Params_Delete_Shops_By_TENANTS_ID i_Params_Delete_Shops_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Shops_By_TENANTS_ID);
            await _databaseContext.Execute<Shops>(Enum_Operation_Type.Execute, "UP_DELETE_SHOPS_BY_TENANTS_ID", _params);

            _logger.LogInformation("Delete_Shops_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Shops(Shops i_Shops)
    {
        var operation = i_Shops.SHOPS_ID == -1 ? "Create New Shops" : "Update Existing Shops";

        try
        {
            _logger.LogInformation("Initiating Edit_Shops operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Shops);
            _params.Add("SHOPS_ID", i_Shops.SHOPS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Shops.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Shops.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Shops>(Enum_Operation_Type.Execute, "UP_EDIT_SHOPS", _params);

            i_Shops.SHOPS_ID = _params.Get<int>("SHOPS_ID");
            i_Shops.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Shops.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Shops operation at the repository layer completed successfully: {Operation}. Shops ID: {SHOPS_ID}", operation, i_Shops.SHOPS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Tenant(Params_Delete_Tenant i_Params_Delete_Tenant)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenant operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenant);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Tenant);
            await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Execute, "UP_DELETE_TENANT", _params);

            _logger.LogInformation("Delete_Tenant operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenant);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenant operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenant);
            throw;
        }
    }

    public async Task Delete_Tenant_By_IS_DELETED(Params_Delete_Tenant_By_IS_DELETED i_Params_Delete_Tenant_By_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenant_By_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Tenant_By_IS_DELETED);
            await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Execute, "UP_DELETE_TENANT_BY_IS_DELETED", _params);

            _logger.LogInformation("Delete_Tenant_By_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenant_By_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);
            throw;
        }
    }

    public async Task Edit_Tenant(Tenant i_Tenant)
    {
        var operation = i_Tenant.TENANT_ID == -1 ? "Create New Tenant" : "Update Existing Tenant";

        try
        {
            _logger.LogInformation("Initiating Edit_Tenant operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Tenant);
            _params.Add("TENANT_ID", i_Tenant.TENANT_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Tenant.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Tenant.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Execute, "UP_EDIT_TENANT", _params);

            i_Tenant.TENANT_ID = _params.Get<int>("TENANT_ID");
            i_Tenant.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Tenant.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Tenant operation at the repository layer completed successfully: {Operation}. Tenant ID: {TENANT_ID}", operation, i_Tenant.TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Tenants(Params_Delete_Tenants i_Params_Delete_Tenants)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenants operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenants);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Tenants);
            await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Execute, "UP_DELETE_TENANTS", _params);

            _logger.LogInformation("Delete_Tenants operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenants);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenants operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenants);
            throw;
        }
    }

    public async Task Delete_Tenants_By_TENANT_ID(Params_Delete_Tenants_By_TENANT_ID i_Params_Delete_Tenants_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenants_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Tenants_By_TENANT_ID);
            await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Execute, "UP_DELETE_TENANTS_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_Tenants_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenants_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_Tenants(Tenants i_Tenants)
    {
        var operation = i_Tenants.TENANTS_ID == -1 ? "Create New Tenants" : "Update Existing Tenants";

        try
        {
            _logger.LogInformation("Initiating Edit_Tenants operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Tenants);
            _params.Add("TENANTS_ID", i_Tenants.TENANTS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Tenants.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Tenants.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Execute, "UP_EDIT_TENANTS", _params);

            i_Tenants.TENANTS_ID = _params.Get<int>("TENANTS_ID");
            i_Tenants.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Tenants.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Tenants operation at the repository layer completed successfully: {Operation}. Tenants ID: {TENANTS_ID}", operation, i_Tenants.TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_User(Params_Delete_User i_Params_Delete_User)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER", _params);

            _logger.LogInformation("Delete_User operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User);
            throw;
        }
    }

    public async Task Delete_User_By_EMAIL_TENANT_ID(Params_Delete_User_By_EMAIL_TENANT_ID i_Params_Delete_User_By_EMAIL_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_EMAIL_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_EMAIL_TENANT_ID);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_EMAIL_TENANT_ID", _params);

            _logger.LogInformation("Delete_User_By_EMAIL_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_EMAIL_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_User_By_TENANT_ID(Params_Delete_User_By_TENANT_ID i_Params_Delete_User_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_TENANT_ID);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_TENANT_ID", _params);

            _logger.LogInformation("Delete_User_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_User_By_TENANT_ID_IS_DELETED(Params_Delete_User_By_TENANT_ID_IS_DELETED i_Params_Delete_User_By_TENANT_ID_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_TENANT_ID_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_TENANT_ID_IS_DELETED", _params);

            _logger.LogInformation("Delete_User_By_TENANT_ID_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_TENANT_ID_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
            throw;
        }
    }

    public async Task Delete_User_By_USER_TYPE_SETUP_ID(Params_Delete_User_By_USER_TYPE_SETUP_ID i_Params_Delete_User_By_USER_TYPE_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_USER_TYPE_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_USER_TYPE_SETUP_ID", _params);

            _logger.LogInformation("Delete_User_By_USER_TYPE_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_USER_TYPE_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
            throw;
        }
    }

    public async Task Delete_User_By_USERNAME_TENANT_ID(Params_Delete_User_By_USERNAME_TENANT_ID i_Params_Delete_User_By_USERNAME_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_USERNAME_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_USERNAME_TENANT_ID);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_USERNAME_TENANT_ID", _params);

            _logger.LogInformation("Delete_User_By_USERNAME_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_USERNAME_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_User(User i_User)
    {
        var operation = i_User.USER_ID == -1 ? "Create New User" : "Update Existing User";

        try
        {
            _logger.LogInformation("Initiating Edit_User operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_User);
            _params.Add("USER_ID", i_User.USER_ID, DbType.Int64, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_User.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_User.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_EDIT_USER", _params);

            i_User.USER_ID = _params.Get<long>("USER_ID");
            i_User.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_User.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_User operation at the repository layer completed successfully: {Operation}. User ID: {USER_ID}", operation, i_User.USER_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }
}
