using Microsoft.Extensions.Logging;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Common.Utilities;
using ShopeManagementApp.Common.Exceptions;

namespace ShopeManagementApp.Application.Services;

public partial class BusinessService
{
    public async Task Delete_Addresses(Params_Delete_Addresses i_Params_Delete_Addresses)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses);

            await _businessRepository.Delete_Addresses(i_Params_Delete_Addresses);

            _logger.LogInformation("Delete_Addresses operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Addresses_By_CUSTOMERS_ID(Params_Delete_Addresses_By_CUSTOMERS_ID i_Params_Delete_Addresses_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses_By_CUSTOMERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);

            await _businessRepository.Delete_Addresses_By_CUSTOMERS_ID(i_Params_Delete_Addresses_By_CUSTOMERS_ID);

            _logger.LogInformation("Delete_Addresses_By_CUSTOMERS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses_By_CUSTOMERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Addresses_By_TENANT_ID(Params_Delete_Addresses_By_TENANT_ID i_Params_Delete_Addresses_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);

            await _businessRepository.Delete_Addresses_By_TENANT_ID(i_Params_Delete_Addresses_By_TENANT_ID);

            _logger.LogInformation("Delete_Addresses_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Addresses(Addresses i_Addresses)
    {
        var operation = i_Addresses.ADDRESSES_ID == -1 ? "Create New Addresses" : "Update Existing Addresses";

        try
        {
            _logger.LogInformation("Initiating Edit_Addresses operation at the service layer: {Operation}.", operation);

            if (i_Addresses.ADDRESSES_ID == 0 || i_Addresses.ADDRESSES_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Addresses.ADDRESSES_ID.ToString() }, { "%2", "Edit_Addresses" } });
            }

            i_Addresses.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Addresses.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Addresses.ADDRESSES_ID == -1)
            {
                i_Addresses.IS_DELETED = false;
            }

            await _businessRepository.Edit_Addresses(i_Addresses);

            _logger.LogInformation("Edit_Addresses operation at the service layer completed successfully: {Operation}. Addresses ID: {Addresses_id}", operation, i_Addresses.ADDRESSES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Addresses_List(Params_Edit_Addresses_List i_Params_Edit_Addresses_List)
    {
        _logger.LogInformation("Initiating Edit_Addresses_List operation at the repository layer.");

        if (i_Params_Edit_Addresses_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Addresses_List.List_To_Edit.Count());

            (i_Params_Edit_Addresses_List.List_To_Edit, i_Params_Edit_Addresses_List.List_Failed_Edit) = await i_Params_Edit_Addresses_List.List_To_Edit.ProcessBatchOperations(
                Edit_Addresses,
                oAddresses => oAddresses
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Addresses_List.List_To_Edit.Count(), i_Params_Edit_Addresses_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Addresses_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Addresses_List.List_To_Delete.Count());

            (i_Params_Edit_Addresses_List.List_To_Delete, i_Params_Edit_Addresses_List.List_Failed_Delete) = await i_Params_Edit_Addresses_List.List_To_Delete.ProcessBatchOperations(
                async oAddresses_ID => await Delete_Addresses(new() { ADDRESSES_ID = oAddresses_ID }),
                oAddresses_ID => oAddresses_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Addresses_List.List_To_Delete.Count(), i_Params_Edit_Addresses_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Addresses_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Admins(Params_Delete_Admins i_Params_Delete_Admins)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins);

            await _businessRepository.Delete_Admins(i_Params_Delete_Admins);

            _logger.LogInformation("Delete_Admins operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Admins_By_TENANT_ID(Params_Delete_Admins_By_TENANT_ID i_Params_Delete_Admins_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);

            await _businessRepository.Delete_Admins_By_TENANT_ID(i_Params_Delete_Admins_By_TENANT_ID);

            _logger.LogInformation("Delete_Admins_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Admins_By_TENANTS_ID(Params_Delete_Admins_By_TENANTS_ID i_Params_Delete_Admins_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);

            await _businessRepository.Delete_Admins_By_TENANTS_ID(i_Params_Delete_Admins_By_TENANTS_ID);

            _logger.LogInformation("Delete_Admins_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Admins(Admins i_Admins)
    {
        var operation = i_Admins.ADMINS_ID == -1 ? "Create New Admins" : "Update Existing Admins";

        try
        {
            _logger.LogInformation("Initiating Edit_Admins operation at the service layer: {Operation}.", operation);

            if (i_Admins.ADMINS_ID == 0 || i_Admins.ADMINS_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Admins.ADMINS_ID.ToString() }, { "%2", "Edit_Admins" } });
            }

            i_Admins.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Admins.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Admins.ADMINS_ID == -1)
            {
                i_Admins.IS_DELETED = false;
            }

            await _businessRepository.Edit_Admins(i_Admins);

            _logger.LogInformation("Edit_Admins operation at the service layer completed successfully: {Operation}. Admins ID: {Admins_id}", operation, i_Admins.ADMINS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Admins_List(Params_Edit_Admins_List i_Params_Edit_Admins_List)
    {
        _logger.LogInformation("Initiating Edit_Admins_List operation at the repository layer.");

        if (i_Params_Edit_Admins_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Admins_List.List_To_Edit.Count());

            (i_Params_Edit_Admins_List.List_To_Edit, i_Params_Edit_Admins_List.List_Failed_Edit) = await i_Params_Edit_Admins_List.List_To_Edit.ProcessBatchOperations(
                Edit_Admins,
                oAdmins => oAdmins
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Admins_List.List_To_Edit.Count(), i_Params_Edit_Admins_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Admins_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Admins_List.List_To_Delete.Count());

            (i_Params_Edit_Admins_List.List_To_Delete, i_Params_Edit_Admins_List.List_Failed_Delete) = await i_Params_Edit_Admins_List.List_To_Delete.ProcessBatchOperations(
                async oAdmins_ID => await Delete_Admins(new() { ADMINS_ID = oAdmins_ID }),
                oAdmins_ID => oAdmins_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Admins_List.List_To_Delete.Count(), i_Params_Edit_Admins_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Admins_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Customers(Params_Delete_Customers i_Params_Delete_Customers)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers);

            await _businessRepository.Delete_Customers(i_Params_Delete_Customers);

            _logger.LogInformation("Delete_Customers operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Customers_By_TENANT_ID(Params_Delete_Customers_By_TENANT_ID i_Params_Delete_Customers_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);

            await _businessRepository.Delete_Customers_By_TENANT_ID(i_Params_Delete_Customers_By_TENANT_ID);

            _logger.LogInformation("Delete_Customers_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Customers_By_TENANTS_ID(Params_Delete_Customers_By_TENANTS_ID i_Params_Delete_Customers_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);

            await _businessRepository.Delete_Customers_By_TENANTS_ID(i_Params_Delete_Customers_By_TENANTS_ID);

            _logger.LogInformation("Delete_Customers_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Customers(Customers i_Customers)
    {
        var operation = i_Customers.CUSTOMERS_ID == -1 ? "Create New Customers" : "Update Existing Customers";

        try
        {
            _logger.LogInformation("Initiating Edit_Customers operation at the service layer: {Operation}.", operation);

            if (i_Customers.CUSTOMERS_ID == 0 || i_Customers.CUSTOMERS_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Customers.CUSTOMERS_ID.ToString() }, { "%2", "Edit_Customers" } });
            }

            i_Customers.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Customers.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Customers.CUSTOMERS_ID == -1)
            {
                i_Customers.IS_DELETED = false;
            }

            await _businessRepository.Edit_Customers(i_Customers);

            _logger.LogInformation("Edit_Customers operation at the service layer completed successfully: {Operation}. Customers ID: {Customers_id}", operation, i_Customers.CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Customers_List(Params_Edit_Customers_List i_Params_Edit_Customers_List)
    {
        _logger.LogInformation("Initiating Edit_Customers_List operation at the repository layer.");

        if (i_Params_Edit_Customers_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Customers_List.List_To_Edit.Count());

            (i_Params_Edit_Customers_List.List_To_Edit, i_Params_Edit_Customers_List.List_Failed_Edit) = await i_Params_Edit_Customers_List.List_To_Edit.ProcessBatchOperations(
                Edit_Customers,
                oCustomers => oCustomers
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Customers_List.List_To_Edit.Count(), i_Params_Edit_Customers_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Customers_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Customers_List.List_To_Delete.Count());

            (i_Params_Edit_Customers_List.List_To_Delete, i_Params_Edit_Customers_List.List_Failed_Delete) = await i_Params_Edit_Customers_List.List_To_Delete.ProcessBatchOperations(
                async oCustomers_ID => await Delete_Customers(new() { CUSTOMERS_ID = oCustomers_ID }),
                oCustomers_ID => oCustomers_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Customers_List.List_To_Delete.Count(), i_Params_Edit_Customers_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Customers_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Order_details(Params_Delete_Order_details i_Params_Delete_Order_details)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details);

            await _businessRepository.Delete_Order_details(i_Params_Delete_Order_details);

            _logger.LogInformation("Delete_Order_details operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Order_details_By_ORDERS_ID(Params_Delete_Order_details_By_ORDERS_ID i_Params_Delete_Order_details_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_ORDERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);

            await _businessRepository.Delete_Order_details_By_ORDERS_ID(i_Params_Delete_Order_details_By_ORDERS_ID);

            _logger.LogInformation("Delete_Order_details_By_ORDERS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_ORDERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Order_details_By_PRODUCTS_ID(Params_Delete_Order_details_By_PRODUCTS_ID i_Params_Delete_Order_details_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_PRODUCTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);

            await _businessRepository.Delete_Order_details_By_PRODUCTS_ID(i_Params_Delete_Order_details_By_PRODUCTS_ID);

            _logger.LogInformation("Delete_Order_details_By_PRODUCTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_PRODUCTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Order_details_By_TENANT_ID(Params_Delete_Order_details_By_TENANT_ID i_Params_Delete_Order_details_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);

            await _businessRepository.Delete_Order_details_By_TENANT_ID(i_Params_Delete_Order_details_By_TENANT_ID);

            _logger.LogInformation("Delete_Order_details_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Order_details_By_TENANTS_ID(Params_Delete_Order_details_By_TENANTS_ID i_Params_Delete_Order_details_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);

            await _businessRepository.Delete_Order_details_By_TENANTS_ID(i_Params_Delete_Order_details_By_TENANTS_ID);

            _logger.LogInformation("Delete_Order_details_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Order_details(Order_details i_Order_details)
    {
        var operation = i_Order_details.ORDER_DETAILS_ID == -1 ? "Create New Order_details" : "Update Existing Order_details";

        try
        {
            _logger.LogInformation("Initiating Edit_Order_details operation at the service layer: {Operation}.", operation);

            if (i_Order_details.ORDER_DETAILS_ID == 0 || i_Order_details.ORDER_DETAILS_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Order_details.ORDER_DETAILS_ID.ToString() }, { "%2", "Edit_Order_details" } });
            }

            i_Order_details.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Order_details.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Order_details.ORDER_DETAILS_ID == -1)
            {
                i_Order_details.IS_DELETED = false;
            }

            await _businessRepository.Edit_Order_details(i_Order_details);

            _logger.LogInformation("Edit_Order_details operation at the service layer completed successfully: {Operation}. Order_details ID: {Order_details_id}", operation, i_Order_details.ORDER_DETAILS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Order_details_List(Params_Edit_Order_details_List i_Params_Edit_Order_details_List)
    {
        _logger.LogInformation("Initiating Edit_Order_details_List operation at the repository layer.");

        if (i_Params_Edit_Order_details_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Order_details_List.List_To_Edit.Count());

            (i_Params_Edit_Order_details_List.List_To_Edit, i_Params_Edit_Order_details_List.List_Failed_Edit) = await i_Params_Edit_Order_details_List.List_To_Edit.ProcessBatchOperations(
                Edit_Order_details,
                oOrder_details => oOrder_details
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Order_details_List.List_To_Edit.Count(), i_Params_Edit_Order_details_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Order_details_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Order_details_List.List_To_Delete.Count());

            (i_Params_Edit_Order_details_List.List_To_Delete, i_Params_Edit_Order_details_List.List_Failed_Delete) = await i_Params_Edit_Order_details_List.List_To_Delete.ProcessBatchOperations(
                async oOrder_details_ID => await Delete_Order_details(new() { ORDER_DETAILS_ID = oOrder_details_ID }),
                oOrder_details_ID => oOrder_details_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Order_details_List.List_To_Delete.Count(), i_Params_Edit_Order_details_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Order_details_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Orders(Params_Delete_Orders i_Params_Delete_Orders)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders);

            await _businessRepository.Delete_Orders(i_Params_Delete_Orders);

            _logger.LogInformation("Delete_Orders operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Orders_By_CUSTOMERS_ID(Params_Delete_Orders_By_CUSTOMERS_ID i_Params_Delete_Orders_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_CUSTOMERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);

            await _businessRepository.Delete_Orders_By_CUSTOMERS_ID(i_Params_Delete_Orders_By_CUSTOMERS_ID);

            _logger.LogInformation("Delete_Orders_By_CUSTOMERS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_CUSTOMERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Orders_By_PROMO_CODES_ID(Params_Delete_Orders_By_PROMO_CODES_ID i_Params_Delete_Orders_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_PROMO_CODES_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);

            await _businessRepository.Delete_Orders_By_PROMO_CODES_ID(i_Params_Delete_Orders_By_PROMO_CODES_ID);

            _logger.LogInformation("Delete_Orders_By_PROMO_CODES_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_PROMO_CODES_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Orders_By_TENANT_ID(Params_Delete_Orders_By_TENANT_ID i_Params_Delete_Orders_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);

            await _businessRepository.Delete_Orders_By_TENANT_ID(i_Params_Delete_Orders_By_TENANT_ID);

            _logger.LogInformation("Delete_Orders_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Orders_By_TENANTS_ID(Params_Delete_Orders_By_TENANTS_ID i_Params_Delete_Orders_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);

            await _businessRepository.Delete_Orders_By_TENANTS_ID(i_Params_Delete_Orders_By_TENANTS_ID);

            _logger.LogInformation("Delete_Orders_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Orders(Orders i_Orders)
    {
        var operation = i_Orders.ORDERS_ID == -1 ? "Create New Orders" : "Update Existing Orders";

        try
        {
            _logger.LogInformation("Initiating Edit_Orders operation at the service layer: {Operation}.", operation);

            if (i_Orders.ORDERS_ID == 0 || i_Orders.ORDERS_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Orders.ORDERS_ID.ToString() }, { "%2", "Edit_Orders" } });
            }

            i_Orders.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Orders.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Orders.ORDERS_ID == -1)
            {
                i_Orders.IS_DELETED = false;
            }

            await _businessRepository.Edit_Orders(i_Orders);

            _logger.LogInformation("Edit_Orders operation at the service layer completed successfully: {Operation}. Orders ID: {Orders_id}", operation, i_Orders.ORDERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Orders_List(Params_Edit_Orders_List i_Params_Edit_Orders_List)
    {
        _logger.LogInformation("Initiating Edit_Orders_List operation at the repository layer.");

        if (i_Params_Edit_Orders_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Orders_List.List_To_Edit.Count());

            (i_Params_Edit_Orders_List.List_To_Edit, i_Params_Edit_Orders_List.List_Failed_Edit) = await i_Params_Edit_Orders_List.List_To_Edit.ProcessBatchOperations(
                Edit_Orders,
                oOrders => oOrders
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Orders_List.List_To_Edit.Count(), i_Params_Edit_Orders_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Orders_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Orders_List.List_To_Delete.Count());

            (i_Params_Edit_Orders_List.List_To_Delete, i_Params_Edit_Orders_List.List_Failed_Delete) = await i_Params_Edit_Orders_List.List_To_Delete.ProcessBatchOperations(
                async oOrders_ID => await Delete_Orders(new() { ORDERS_ID = oOrders_ID }),
                oOrders_ID => oOrders_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Orders_List.List_To_Delete.Count(), i_Params_Edit_Orders_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Orders_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Products(Params_Delete_Products i_Params_Delete_Products)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products);

            await _businessRepository.Delete_Products(i_Params_Delete_Products);

            _logger.LogInformation("Delete_Products operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Products_By_SHOPS_ID(Params_Delete_Products_By_SHOPS_ID i_Params_Delete_Products_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_SHOPS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);

            await _businessRepository.Delete_Products_By_SHOPS_ID(i_Params_Delete_Products_By_SHOPS_ID);

            _logger.LogInformation("Delete_Products_By_SHOPS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_SHOPS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Products_By_TENANT_ID(Params_Delete_Products_By_TENANT_ID i_Params_Delete_Products_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);

            await _businessRepository.Delete_Products_By_TENANT_ID(i_Params_Delete_Products_By_TENANT_ID);

            _logger.LogInformation("Delete_Products_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Products_By_TENANTS_ID(Params_Delete_Products_By_TENANTS_ID i_Params_Delete_Products_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);

            await _businessRepository.Delete_Products_By_TENANTS_ID(i_Params_Delete_Products_By_TENANTS_ID);

            _logger.LogInformation("Delete_Products_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Products(Products i_Products)
    {
        var operation = i_Products.PRODUCTS_ID == -1 ? "Create New Products" : "Update Existing Products";

        try
        {
            _logger.LogInformation("Initiating Edit_Products operation at the service layer: {Operation}.", operation);

            if (i_Products.PRODUCTS_ID == 0 || i_Products.PRODUCTS_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Products.PRODUCTS_ID.ToString() }, { "%2", "Edit_Products" } });
            }

            i_Products.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Products.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Products.PRODUCTS_ID == -1)
            {
                i_Products.IS_DELETED = false;
            }

            await _businessRepository.Edit_Products(i_Products);

            _logger.LogInformation("Edit_Products operation at the service layer completed successfully: {Operation}. Products ID: {Products_id}", operation, i_Products.PRODUCTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Products_List(Params_Edit_Products_List i_Params_Edit_Products_List)
    {
        _logger.LogInformation("Initiating Edit_Products_List operation at the repository layer.");

        if (i_Params_Edit_Products_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Products_List.List_To_Edit.Count());

            (i_Params_Edit_Products_List.List_To_Edit, i_Params_Edit_Products_List.List_Failed_Edit) = await i_Params_Edit_Products_List.List_To_Edit.ProcessBatchOperations(
                Edit_Products,
                oProducts => oProducts
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Products_List.List_To_Edit.Count(), i_Params_Edit_Products_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Products_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Products_List.List_To_Delete.Count());

            (i_Params_Edit_Products_List.List_To_Delete, i_Params_Edit_Products_List.List_Failed_Delete) = await i_Params_Edit_Products_List.List_To_Delete.ProcessBatchOperations(
                async oProducts_ID => await Delete_Products(new() { PRODUCTS_ID = oProducts_ID }),
                oProducts_ID => oProducts_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Products_List.List_To_Delete.Count(), i_Params_Edit_Products_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Products_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Promo_codes(Params_Delete_Promo_codes i_Params_Delete_Promo_codes)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes);

            await _businessRepository.Delete_Promo_codes(i_Params_Delete_Promo_codes);

            _logger.LogInformation("Delete_Promo_codes operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Promo_codes_By_TENANT_ID(Params_Delete_Promo_codes_By_TENANT_ID i_Params_Delete_Promo_codes_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);

            await _businessRepository.Delete_Promo_codes_By_TENANT_ID(i_Params_Delete_Promo_codes_By_TENANT_ID);

            _logger.LogInformation("Delete_Promo_codes_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Promo_codes_By_TENANTS_ID(Params_Delete_Promo_codes_By_TENANTS_ID i_Params_Delete_Promo_codes_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);

            await _businessRepository.Delete_Promo_codes_By_TENANTS_ID(i_Params_Delete_Promo_codes_By_TENANTS_ID);

            _logger.LogInformation("Delete_Promo_codes_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Promo_codes(Promo_codes i_Promo_codes)
    {
        var operation = i_Promo_codes.PROMO_CODES_ID == -1 ? "Create New Promo_codes" : "Update Existing Promo_codes";

        try
        {
            _logger.LogInformation("Initiating Edit_Promo_codes operation at the service layer: {Operation}.", operation);

            if (i_Promo_codes.PROMO_CODES_ID == 0 || i_Promo_codes.PROMO_CODES_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Promo_codes.PROMO_CODES_ID.ToString() }, { "%2", "Edit_Promo_codes" } });
            }

            i_Promo_codes.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Promo_codes.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Promo_codes.PROMO_CODES_ID == -1)
            {
                i_Promo_codes.IS_DELETED = false;
            }

            await _businessRepository.Edit_Promo_codes(i_Promo_codes);

            _logger.LogInformation("Edit_Promo_codes operation at the service layer completed successfully: {Operation}. Promo_codes ID: {Promo_codes_id}", operation, i_Promo_codes.PROMO_CODES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Promo_codes_List(Params_Edit_Promo_codes_List i_Params_Edit_Promo_codes_List)
    {
        _logger.LogInformation("Initiating Edit_Promo_codes_List operation at the repository layer.");

        if (i_Params_Edit_Promo_codes_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Promo_codes_List.List_To_Edit.Count());

            (i_Params_Edit_Promo_codes_List.List_To_Edit, i_Params_Edit_Promo_codes_List.List_Failed_Edit) = await i_Params_Edit_Promo_codes_List.List_To_Edit.ProcessBatchOperations(
                Edit_Promo_codes,
                oPromo_codes => oPromo_codes
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Promo_codes_List.List_To_Edit.Count(), i_Params_Edit_Promo_codes_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Promo_codes_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Promo_codes_List.List_To_Delete.Count());

            (i_Params_Edit_Promo_codes_List.List_To_Delete, i_Params_Edit_Promo_codes_List.List_Failed_Delete) = await i_Params_Edit_Promo_codes_List.List_To_Delete.ProcessBatchOperations(
                async oPromo_codes_ID => await Delete_Promo_codes(new() { PROMO_CODES_ID = oPromo_codes_ID }),
                oPromo_codes_ID => oPromo_codes_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Promo_codes_List.List_To_Delete.Count(), i_Params_Edit_Promo_codes_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Promo_codes_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup);

            await _businessRepository.Delete_Setup(i_Params_Delete_Setup);

            _logger.LogInformation("Delete_Setup operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_SETUP_CATEGORY_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            await _businessRepository.Delete_Setup_By_SETUP_CATEGORY_ID(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            _logger.LogInformation("Delete_Setup_By_SETUP_CATEGORY_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_SETUP_CATEGORY_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            await _businessRepository.Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            _logger.LogInformation("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Setup_By_TENANT_ID(Params_Delete_Setup_By_TENANT_ID i_Params_Delete_Setup_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);

            await _businessRepository.Delete_Setup_By_TENANT_ID(i_Params_Delete_Setup_By_TENANT_ID);

            _logger.LogInformation("Delete_Setup_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Setup(Setup i_Setup)
    {
        var operation = i_Setup.SETUP_ID == -1 ? "Create New Setup" : "Update Existing Setup";

        try
        {
            _logger.LogInformation("Initiating Edit_Setup operation at the service layer: {Operation}.", operation);

            if (i_Setup.SETUP_ID == 0 || i_Setup.SETUP_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Setup.SETUP_ID.ToString() }, { "%2", "Edit_Setup" } });
            }

            i_Setup.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Setup.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Setup.SETUP_ID == -1)
            {
                i_Setup.IS_DELETED = false;
            }

            await _businessRepository.Edit_Setup(i_Setup);

            _logger.LogInformation("Edit_Setup operation at the service layer completed successfully: {Operation}. Setup ID: {Setup_id}", operation, i_Setup.SETUP_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Setup_List(Params_Edit_Setup_List i_Params_Edit_Setup_List)
    {
        _logger.LogInformation("Initiating Edit_Setup_List operation at the repository layer.");

        if (i_Params_Edit_Setup_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Setup_List.List_To_Edit.Count());

            (i_Params_Edit_Setup_List.List_To_Edit, i_Params_Edit_Setup_List.List_Failed_Edit) = await i_Params_Edit_Setup_List.List_To_Edit.ProcessBatchOperations(
                Edit_Setup,
                oSetup => oSetup
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Setup_List.List_To_Edit.Count(), i_Params_Edit_Setup_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Setup_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Setup_List.List_To_Delete.Count());

            (i_Params_Edit_Setup_List.List_To_Delete, i_Params_Edit_Setup_List.List_Failed_Delete) = await i_Params_Edit_Setup_List.List_To_Delete.ProcessBatchOperations(
                async oSetup_ID => await Delete_Setup(new() { SETUP_ID = oSetup_ID }),
                oSetup_ID => oSetup_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Setup_List.List_To_Delete.Count(), i_Params_Edit_Setup_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Setup_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_category operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_category);

            await _businessRepository.Delete_Setup_category(i_Params_Delete_Setup_category);

            _logger.LogInformation("Delete_Setup_category operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_category);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_category operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_category);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Setup_category_By_TENANT_ID(Params_Delete_Setup_category_By_TENANT_ID i_Params_Delete_Setup_category_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_category_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);

            await _businessRepository.Delete_Setup_category_By_TENANT_ID(i_Params_Delete_Setup_category_By_TENANT_ID);

            _logger.LogInformation("Delete_Setup_category_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_category_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Setup_category(Setup_category i_Setup_category)
    {
        var operation = i_Setup_category.SETUP_CATEGORY_ID == -1 ? "Create New Setup_category" : "Update Existing Setup_category";

        try
        {
            _logger.LogInformation("Initiating Edit_Setup_category operation at the service layer: {Operation}.", operation);

            if (i_Setup_category.SETUP_CATEGORY_ID == 0 || i_Setup_category.SETUP_CATEGORY_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Setup_category.SETUP_CATEGORY_ID.ToString() }, { "%2", "Edit_Setup_category" } });
            }

            i_Setup_category.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Setup_category.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Setup_category.SETUP_CATEGORY_ID == -1)
            {
                i_Setup_category.IS_DELETED = false;
            }

            await _businessRepository.Edit_Setup_category(i_Setup_category);

            _logger.LogInformation("Edit_Setup_category operation at the service layer completed successfully: {Operation}. Setup_category ID: {Setup_category_id}", operation, i_Setup_category.SETUP_CATEGORY_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
    {
        _logger.LogInformation("Initiating Edit_Setup_category_List operation at the repository layer.");

        if (i_Params_Edit_Setup_category_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Setup_category_List.List_To_Edit.Count());

            (i_Params_Edit_Setup_category_List.List_To_Edit, i_Params_Edit_Setup_category_List.List_Failed_Edit) = await i_Params_Edit_Setup_category_List.List_To_Edit.ProcessBatchOperations(
                Edit_Setup_category,
                oSetup_category => oSetup_category
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Setup_category_List.List_To_Edit.Count(), i_Params_Edit_Setup_category_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Setup_category_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Setup_category_List.List_To_Delete.Count());

            (i_Params_Edit_Setup_category_List.List_To_Delete, i_Params_Edit_Setup_category_List.List_Failed_Delete) = await i_Params_Edit_Setup_category_List.List_To_Delete.ProcessBatchOperations(
                async oSetup_category_ID => await Delete_Setup_category(new() { SETUP_CATEGORY_ID = oSetup_category_ID }),
                oSetup_category_ID => oSetup_category_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Setup_category_List.List_To_Delete.Count(), i_Params_Edit_Setup_category_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Setup_category_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Shops(Params_Delete_Shops i_Params_Delete_Shops)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops);

            await _businessRepository.Delete_Shops(i_Params_Delete_Shops);

            _logger.LogInformation("Delete_Shops operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Shops_By_TENANT_ID(Params_Delete_Shops_By_TENANT_ID i_Params_Delete_Shops_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);

            await _businessRepository.Delete_Shops_By_TENANT_ID(i_Params_Delete_Shops_By_TENANT_ID);

            _logger.LogInformation("Delete_Shops_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Shops_By_TENANTS_ID(Params_Delete_Shops_By_TENANTS_ID i_Params_Delete_Shops_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);

            await _businessRepository.Delete_Shops_By_TENANTS_ID(i_Params_Delete_Shops_By_TENANTS_ID);

            _logger.LogInformation("Delete_Shops_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Shops(Shops i_Shops)
    {
        var operation = i_Shops.SHOPS_ID == -1 ? "Create New Shops" : "Update Existing Shops";

        try
        {
            _logger.LogInformation("Initiating Edit_Shops operation at the service layer: {Operation}.", operation);

            if (i_Shops.SHOPS_ID == 0 || i_Shops.SHOPS_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Shops.SHOPS_ID.ToString() }, { "%2", "Edit_Shops" } });
            }

            i_Shops.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Shops.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Shops.SHOPS_ID == -1)
            {
                i_Shops.IS_DELETED = false;
            }

            await _businessRepository.Edit_Shops(i_Shops);

            _logger.LogInformation("Edit_Shops operation at the service layer completed successfully: {Operation}. Shops ID: {Shops_id}", operation, i_Shops.SHOPS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Shops_List(Params_Edit_Shops_List i_Params_Edit_Shops_List)
    {
        _logger.LogInformation("Initiating Edit_Shops_List operation at the repository layer.");

        if (i_Params_Edit_Shops_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Shops_List.List_To_Edit.Count());

            (i_Params_Edit_Shops_List.List_To_Edit, i_Params_Edit_Shops_List.List_Failed_Edit) = await i_Params_Edit_Shops_List.List_To_Edit.ProcessBatchOperations(
                Edit_Shops,
                oShops => oShops
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Shops_List.List_To_Edit.Count(), i_Params_Edit_Shops_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Shops_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Shops_List.List_To_Delete.Count());

            (i_Params_Edit_Shops_List.List_To_Delete, i_Params_Edit_Shops_List.List_Failed_Delete) = await i_Params_Edit_Shops_List.List_To_Delete.ProcessBatchOperations(
                async oShops_ID => await Delete_Shops(new() { SHOPS_ID = oShops_ID }),
                oShops_ID => oShops_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Shops_List.List_To_Delete.Count(), i_Params_Edit_Shops_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Shops_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Tenant(Params_Delete_Tenant i_Params_Delete_Tenant)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenant operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenant);

            await _businessRepository.Delete_Tenant(i_Params_Delete_Tenant);

            _logger.LogInformation("Delete_Tenant operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenant);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenant operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenant);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Tenant_By_IS_DELETED(Params_Delete_Tenant_By_IS_DELETED i_Params_Delete_Tenant_By_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenant_By_IS_DELETED operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);

            await _businessRepository.Delete_Tenant_By_IS_DELETED(i_Params_Delete_Tenant_By_IS_DELETED);

            _logger.LogInformation("Delete_Tenant_By_IS_DELETED operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenant_By_IS_DELETED operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Tenant(Tenant i_Tenant)
    {
        var operation = i_Tenant.TENANT_ID == -1 ? "Create New Tenant" : "Update Existing Tenant";

        try
        {
            _logger.LogInformation("Initiating Edit_Tenant operation at the service layer: {Operation}.", operation);

            if (i_Tenant.TENANT_ID == 0 || i_Tenant.TENANT_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Tenant.TENANT_ID.ToString() }, { "%2", "Edit_Tenant" } });
            }

            i_Tenant.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Tenant.TENANT_ID == -1)
            {
                i_Tenant.IS_DELETED = false;
            }

            await _businessRepository.Edit_Tenant(i_Tenant);

            _logger.LogInformation("Edit_Tenant operation at the service layer completed successfully: {Operation}. Tenant ID: {Tenant_id}", operation, i_Tenant.TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Tenant_List(Params_Edit_Tenant_List i_Params_Edit_Tenant_List)
    {
        _logger.LogInformation("Initiating Edit_Tenant_List operation at the repository layer.");

        if (i_Params_Edit_Tenant_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Tenant_List.List_To_Edit.Count());

            (i_Params_Edit_Tenant_List.List_To_Edit, i_Params_Edit_Tenant_List.List_Failed_Edit) = await i_Params_Edit_Tenant_List.List_To_Edit.ProcessBatchOperations(
                Edit_Tenant,
                oTenant => oTenant
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Tenant_List.List_To_Edit.Count(), i_Params_Edit_Tenant_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Tenant_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Tenant_List.List_To_Delete.Count());

            (i_Params_Edit_Tenant_List.List_To_Delete, i_Params_Edit_Tenant_List.List_Failed_Delete) = await i_Params_Edit_Tenant_List.List_To_Delete.ProcessBatchOperations(
                async oTenant_ID => await Delete_Tenant(new() { TENANT_ID = oTenant_ID }),
                oTenant_ID => oTenant_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Tenant_List.List_To_Delete.Count(), i_Params_Edit_Tenant_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Tenant_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Tenants(Params_Delete_Tenants i_Params_Delete_Tenants)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenants operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenants);

            await _businessRepository.Delete_Tenants(i_Params_Delete_Tenants);

            _logger.LogInformation("Delete_Tenants operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenants);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenants operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenants);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Tenants_By_TENANT_ID(Params_Delete_Tenants_By_TENANT_ID i_Params_Delete_Tenants_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenants_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);

            await _businessRepository.Delete_Tenants_By_TENANT_ID(i_Params_Delete_Tenants_By_TENANT_ID);

            _logger.LogInformation("Delete_Tenants_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenants_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Tenants(Tenants i_Tenants)
    {
        var operation = i_Tenants.TENANTS_ID == -1 ? "Create New Tenants" : "Update Existing Tenants";

        try
        {
            _logger.LogInformation("Initiating Edit_Tenants operation at the service layer: {Operation}.", operation);

            if (i_Tenants.TENANTS_ID == 0 || i_Tenants.TENANTS_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Tenants.TENANTS_ID.ToString() }, { "%2", "Edit_Tenants" } });
            }

            i_Tenants.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Tenants.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Tenants.TENANTS_ID == -1)
            {
                i_Tenants.IS_DELETED = false;
            }

            await _businessRepository.Edit_Tenants(i_Tenants);

            _logger.LogInformation("Edit_Tenants operation at the service layer completed successfully: {Operation}. Tenants ID: {Tenants_id}", operation, i_Tenants.TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Tenants_List(Params_Edit_Tenants_List i_Params_Edit_Tenants_List)
    {
        _logger.LogInformation("Initiating Edit_Tenants_List operation at the repository layer.");

        if (i_Params_Edit_Tenants_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Tenants_List.List_To_Edit.Count());

            (i_Params_Edit_Tenants_List.List_To_Edit, i_Params_Edit_Tenants_List.List_Failed_Edit) = await i_Params_Edit_Tenants_List.List_To_Edit.ProcessBatchOperations(
                Edit_Tenants,
                oTenants => oTenants
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Tenants_List.List_To_Edit.Count(), i_Params_Edit_Tenants_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Tenants_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Tenants_List.List_To_Delete.Count());

            (i_Params_Edit_Tenants_List.List_To_Delete, i_Params_Edit_Tenants_List.List_Failed_Delete) = await i_Params_Edit_Tenants_List.List_To_Delete.ProcessBatchOperations(
                async oTenants_ID => await Delete_Tenants(new() { TENANTS_ID = oTenants_ID }),
                oTenants_ID => oTenants_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Tenants_List.List_To_Delete.Count(), i_Params_Edit_Tenants_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Tenants_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_User(Params_Delete_User i_Params_Delete_User)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User operation at the service layer with parameters: {@Params}.", i_Params_Delete_User);

            await _businessRepository.Delete_User(i_Params_Delete_User);

            _logger.LogInformation("Delete_User operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User operation at the service layer with parameters: {@Params}.", i_Params_Delete_User);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_EMAIL_TENANT_ID(Params_Delete_User_By_EMAIL_TENANT_ID i_Params_Delete_User_By_EMAIL_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_EMAIL_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);

            await _businessRepository.Delete_User_By_EMAIL_TENANT_ID(i_Params_Delete_User_By_EMAIL_TENANT_ID);

            _logger.LogInformation("Delete_User_By_EMAIL_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_EMAIL_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_TENANT_ID(Params_Delete_User_By_TENANT_ID i_Params_Delete_User_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);

            await _businessRepository.Delete_User_By_TENANT_ID(i_Params_Delete_User_By_TENANT_ID);

            _logger.LogInformation("Delete_User_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_TENANT_ID_IS_DELETED(Params_Delete_User_By_TENANT_ID_IS_DELETED i_Params_Delete_User_By_TENANT_ID_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_TENANT_ID_IS_DELETED operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);

            await _businessRepository.Delete_User_By_TENANT_ID_IS_DELETED(i_Params_Delete_User_By_TENANT_ID_IS_DELETED);

            _logger.LogInformation("Delete_User_By_TENANT_ID_IS_DELETED operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_TENANT_ID_IS_DELETED operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_USER_TYPE_SETUP_ID(Params_Delete_User_By_USER_TYPE_SETUP_ID i_Params_Delete_User_By_USER_TYPE_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_USER_TYPE_SETUP_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);

            await _businessRepository.Delete_User_By_USER_TYPE_SETUP_ID(i_Params_Delete_User_By_USER_TYPE_SETUP_ID);

            _logger.LogInformation("Delete_User_By_USER_TYPE_SETUP_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_USER_TYPE_SETUP_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_USERNAME_TENANT_ID(Params_Delete_User_By_USERNAME_TENANT_ID i_Params_Delete_User_By_USERNAME_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_USERNAME_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);

            await _businessRepository.Delete_User_By_USERNAME_TENANT_ID(i_Params_Delete_User_By_USERNAME_TENANT_ID);

            _logger.LogInformation("Delete_User_By_USERNAME_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_USERNAME_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);
            await _databaseContext.RollbackAsync();
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_User(User i_User)
    {
        var operation = i_User.USER_ID == -1 ? "Create New User" : "Update Existing User";

        try
        {
            _logger.LogInformation("Initiating Edit_User operation at the service layer: {Operation}.", operation);

            if (i_User.USER_ID == 0 || i_User.USER_ID < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_User.USER_ID.ToString() }, { "%2", "Edit_User" } });
            }

            i_User.TENANT_ID = _userSessionContext.Tenant_ID;
            i_User.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_User.USER_ID == -1)
            {
                i_User.IS_DELETED = false;
            }

            await _businessRepository.Edit_User(i_User);

            _logger.LogInformation("Edit_User operation at the service layer completed successfully: {Operation}. User ID: {User_id}", operation, i_User.USER_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync();
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
    {
        _logger.LogInformation("Initiating Edit_User_List operation at the repository layer.");

        if (i_Params_Edit_User_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_User_List.List_To_Edit.Count());

            (i_Params_Edit_User_List.List_To_Edit, i_Params_Edit_User_List.List_Failed_Edit) = await i_Params_Edit_User_List.List_To_Edit.ProcessBatchOperations(
                Edit_User,
                oUser => oUser
            );

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_User_List.List_To_Edit.Count(), i_Params_Edit_User_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_User_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_User_List.List_To_Delete.Count());

            (i_Params_Edit_User_List.List_To_Delete, i_Params_Edit_User_List.List_Failed_Delete) = await i_Params_Edit_User_List.List_To_Delete.ProcessBatchOperations(
                async oUser_ID => await Delete_User(new() { USER_ID = oUser_ID }),
                oUser_ID => oUser_ID
            );

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_User_List.List_To_Delete.Count(), i_Params_Edit_User_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_User_List operation at the repository layer completed successfully.");
    }
}
