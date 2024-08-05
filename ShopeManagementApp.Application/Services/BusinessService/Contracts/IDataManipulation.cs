using ShopeManagementApp.Domain.Entities;

namespace ShopeManagementApp.Application.Contracts;

public partial interface IBusinessService
{
    Task Delete_Addresses(Params_Delete_Addresses i_Params_Delete_Addresses);
    Task Delete_Addresses_By_CUSTOMERS_ID(Params_Delete_Addresses_By_CUSTOMERS_ID i_Params_Delete_Addresses_By_CUSTOMERS_ID);
    Task Delete_Addresses_By_TENANT_ID(Params_Delete_Addresses_By_TENANT_ID i_Params_Delete_Addresses_By_TENANT_ID);
    Task Edit_Addresses(Addresses i_Addresses);
    Task Edit_Addresses_List(Params_Edit_Addresses_List i_Params_Edit_Addresses_List);
    Task Delete_Admins(Params_Delete_Admins i_Params_Delete_Admins);
    Task Delete_Admins_By_TENANT_ID(Params_Delete_Admins_By_TENANT_ID i_Params_Delete_Admins_By_TENANT_ID);
    Task Delete_Admins_By_TENANTS_ID(Params_Delete_Admins_By_TENANTS_ID i_Params_Delete_Admins_By_TENANTS_ID);
    Task Edit_Admins(Admins i_Admins);
    Task Edit_Admins_List(Params_Edit_Admins_List i_Params_Edit_Admins_List);
    Task Delete_Customers(Params_Delete_Customers i_Params_Delete_Customers);
    Task Delete_Customers_By_TENANT_ID(Params_Delete_Customers_By_TENANT_ID i_Params_Delete_Customers_By_TENANT_ID);
    Task Delete_Customers_By_TENANTS_ID(Params_Delete_Customers_By_TENANTS_ID i_Params_Delete_Customers_By_TENANTS_ID);
    Task Edit_Customers(Customers i_Customers);
    Task Edit_Customers_List(Params_Edit_Customers_List i_Params_Edit_Customers_List);
    Task Delete_Order_details(Params_Delete_Order_details i_Params_Delete_Order_details);
    Task Delete_Order_details_By_ORDERS_ID(Params_Delete_Order_details_By_ORDERS_ID i_Params_Delete_Order_details_By_ORDERS_ID);
    Task Delete_Order_details_By_PRODUCTS_ID(Params_Delete_Order_details_By_PRODUCTS_ID i_Params_Delete_Order_details_By_PRODUCTS_ID);
    Task Delete_Order_details_By_TENANT_ID(Params_Delete_Order_details_By_TENANT_ID i_Params_Delete_Order_details_By_TENANT_ID);
    Task Delete_Order_details_By_TENANTS_ID(Params_Delete_Order_details_By_TENANTS_ID i_Params_Delete_Order_details_By_TENANTS_ID);
    Task Edit_Order_details(Order_details i_Order_details);
    Task Edit_Order_details_List(Params_Edit_Order_details_List i_Params_Edit_Order_details_List);
    Task Delete_Orders(Params_Delete_Orders i_Params_Delete_Orders);
    Task Delete_Orders_By_CUSTOMERS_ID(Params_Delete_Orders_By_CUSTOMERS_ID i_Params_Delete_Orders_By_CUSTOMERS_ID);
    Task Delete_Orders_By_PROMO_CODES_ID(Params_Delete_Orders_By_PROMO_CODES_ID i_Params_Delete_Orders_By_PROMO_CODES_ID);
    Task Delete_Orders_By_TENANT_ID(Params_Delete_Orders_By_TENANT_ID i_Params_Delete_Orders_By_TENANT_ID);
    Task Delete_Orders_By_TENANTS_ID(Params_Delete_Orders_By_TENANTS_ID i_Params_Delete_Orders_By_TENANTS_ID);
    Task Edit_Orders(Orders i_Orders);
    Task Edit_Orders_List(Params_Edit_Orders_List i_Params_Edit_Orders_List);
    Task Delete_Products(Params_Delete_Products i_Params_Delete_Products);
    Task Delete_Products_By_SHOPS_ID(Params_Delete_Products_By_SHOPS_ID i_Params_Delete_Products_By_SHOPS_ID);
    Task Delete_Products_By_TENANT_ID(Params_Delete_Products_By_TENANT_ID i_Params_Delete_Products_By_TENANT_ID);
    Task Delete_Products_By_TENANTS_ID(Params_Delete_Products_By_TENANTS_ID i_Params_Delete_Products_By_TENANTS_ID);
    Task Edit_Products(Products i_Products);
    Task Edit_Products_List(Params_Edit_Products_List i_Params_Edit_Products_List);
    Task Delete_Promo_codes(Params_Delete_Promo_codes i_Params_Delete_Promo_codes);
    Task Delete_Promo_codes_By_TENANT_ID(Params_Delete_Promo_codes_By_TENANT_ID i_Params_Delete_Promo_codes_By_TENANT_ID);
    Task Delete_Promo_codes_By_TENANTS_ID(Params_Delete_Promo_codes_By_TENANTS_ID i_Params_Delete_Promo_codes_By_TENANTS_ID);
    Task Edit_Promo_codes(Promo_codes i_Promo_codes);
    Task Edit_Promo_codes_List(Params_Edit_Promo_codes_List i_Params_Edit_Promo_codes_List);
    Task Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup);
    Task Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
    Task Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
    Task Delete_Setup_By_TENANT_ID(Params_Delete_Setup_By_TENANT_ID i_Params_Delete_Setup_By_TENANT_ID);
    Task Edit_Setup(Setup i_Setup);
    Task Edit_Setup_List(Params_Edit_Setup_List i_Params_Edit_Setup_List);
    Task Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category);
    Task Delete_Setup_category_By_TENANT_ID(Params_Delete_Setup_category_By_TENANT_ID i_Params_Delete_Setup_category_By_TENANT_ID);
    Task Edit_Setup_category(Setup_category i_Setup_category);
    Task Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List);
    Task Delete_Shops(Params_Delete_Shops i_Params_Delete_Shops);
    Task Delete_Shops_By_TENANT_ID(Params_Delete_Shops_By_TENANT_ID i_Params_Delete_Shops_By_TENANT_ID);
    Task Delete_Shops_By_TENANTS_ID(Params_Delete_Shops_By_TENANTS_ID i_Params_Delete_Shops_By_TENANTS_ID);
    Task Edit_Shops(Shops i_Shops);
    Task Edit_Shops_List(Params_Edit_Shops_List i_Params_Edit_Shops_List);
    Task Delete_Tenant(Params_Delete_Tenant i_Params_Delete_Tenant);
    Task Delete_Tenant_By_IS_DELETED(Params_Delete_Tenant_By_IS_DELETED i_Params_Delete_Tenant_By_IS_DELETED);
    Task Edit_Tenant(Tenant i_Tenant);
    Task Edit_Tenant_List(Params_Edit_Tenant_List i_Params_Edit_Tenant_List);
    Task Delete_Tenants(Params_Delete_Tenants i_Params_Delete_Tenants);
    Task Delete_Tenants_By_TENANT_ID(Params_Delete_Tenants_By_TENANT_ID i_Params_Delete_Tenants_By_TENANT_ID);
    Task Edit_Tenants(Tenants i_Tenants);
    Task Edit_Tenants_List(Params_Edit_Tenants_List i_Params_Edit_Tenants_List);
    Task Delete_User(Params_Delete_User i_Params_Delete_User);
    Task Delete_User_By_EMAIL_TENANT_ID(Params_Delete_User_By_EMAIL_TENANT_ID i_Params_Delete_User_By_EMAIL_TENANT_ID);
    Task Delete_User_By_TENANT_ID(Params_Delete_User_By_TENANT_ID i_Params_Delete_User_By_TENANT_ID);
    Task Delete_User_By_TENANT_ID_IS_DELETED(Params_Delete_User_By_TENANT_ID_IS_DELETED i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
    Task Delete_User_By_USER_TYPE_SETUP_ID(Params_Delete_User_By_USER_TYPE_SETUP_ID i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
    Task Delete_User_By_USERNAME_TENANT_ID(Params_Delete_User_By_USERNAME_TENANT_ID i_Params_Delete_User_By_USERNAME_TENANT_ID);
    Task Edit_User(User i_User);
    Task Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List);
}
