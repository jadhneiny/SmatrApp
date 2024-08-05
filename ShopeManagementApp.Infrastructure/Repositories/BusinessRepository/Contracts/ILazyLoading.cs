using ShopeManagementApp.Domain.Entities;

namespace ShopeManagementApp.Infrastructure.Contracts;

public partial interface IBusinessRepository
{
    Task<Addresses> Get_Addresses_By_ADDRESSES_ID(Params_Get_Addresses_By_ADDRESSES_ID i_Params_Get_Addresses_By_ADDRESSES_ID);
    Task<IEnumerable<Addresses>> Get_Addresses_By_ADDRESSES_ID_List(Params_Get_Addresses_By_ADDRESSES_ID_List i_Params_Get_Addresses_By_ADDRESSES_ID_List);
    Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID(Params_Get_Addresses_By_CUSTOMERS_ID i_Params_Get_Addresses_By_CUSTOMERS_ID);
    Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_List(Params_Get_Addresses_By_CUSTOMERS_ID_List i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
    Task<Get_Addresses_By_Properties_Response> Get_Addresses_By_Properties(Params_Get_Addresses_By_Properties i_Params_Get_Addresses_By_Properties);
    Task<IEnumerable<Addresses>> Get_Addresses_By_TENANT_ID(Params_Get_Addresses_By_TENANT_ID i_Params_Get_Addresses_By_TENANT_ID);
    Task<Admins> Get_Admins_By_ADMINS_ID(Params_Get_Admins_By_ADMINS_ID i_Params_Get_Admins_By_ADMINS_ID);
    Task<IEnumerable<Admins>> Get_Admins_By_ADMINS_ID_List(Params_Get_Admins_By_ADMINS_ID_List i_Params_Get_Admins_By_ADMINS_ID_List);
    Task<Get_Admins_By_Properties_Response> Get_Admins_By_Properties(Params_Get_Admins_By_Properties i_Params_Get_Admins_By_Properties);
    Task<IEnumerable<Admins>> Get_Admins_By_TENANT_ID(Params_Get_Admins_By_TENANT_ID i_Params_Get_Admins_By_TENANT_ID);
    Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID(Params_Get_Admins_By_TENANTS_ID i_Params_Get_Admins_By_TENANTS_ID);
    Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID_List(Params_Get_Admins_By_TENANTS_ID_List i_Params_Get_Admins_By_TENANTS_ID_List);
    Task<Customers> Get_Customers_By_CUSTOMERS_ID(Params_Get_Customers_By_CUSTOMERS_ID i_Params_Get_Customers_By_CUSTOMERS_ID);
    Task<IEnumerable<Customers>> Get_Customers_By_CUSTOMERS_ID_List(Params_Get_Customers_By_CUSTOMERS_ID_List i_Params_Get_Customers_By_CUSTOMERS_ID_List);
    Task<Get_Customers_By_Properties_Response> Get_Customers_By_Properties(Params_Get_Customers_By_Properties i_Params_Get_Customers_By_Properties);
    Task<IEnumerable<Customers>> Get_Customers_By_TENANT_ID(Params_Get_Customers_By_TENANT_ID i_Params_Get_Customers_By_TENANT_ID);
    Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID(Params_Get_Customers_By_TENANTS_ID i_Params_Get_Customers_By_TENANTS_ID);
    Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID_List(Params_Get_Customers_By_TENANTS_ID_List i_Params_Get_Customers_By_TENANTS_ID_List);
    Task<Order_details> Get_Order_details_By_ORDER_DETAILS_ID(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_ORDER_DETAILS_ID_List(Params_Get_Order_details_By_ORDER_DETAILS_ID_List i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
    Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID(Params_Get_Order_details_By_ORDERS_ID i_Params_Get_Order_details_By_ORDERS_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID_List(Params_Get_Order_details_By_ORDERS_ID_List i_Params_Get_Order_details_By_ORDERS_ID_List);
    Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID(Params_Get_Order_details_By_PRODUCTS_ID i_Params_Get_Order_details_By_PRODUCTS_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID_List(Params_Get_Order_details_By_PRODUCTS_ID_List i_Params_Get_Order_details_By_PRODUCTS_ID_List);
    Task<Get_Order_details_By_Properties_Response> Get_Order_details_By_Properties(Params_Get_Order_details_By_Properties i_Params_Get_Order_details_By_Properties);
    Task<IEnumerable<Order_details>> Get_Order_details_By_TENANT_ID(Params_Get_Order_details_By_TENANT_ID i_Params_Get_Order_details_By_TENANT_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID(Params_Get_Order_details_By_TENANTS_ID i_Params_Get_Order_details_By_TENANTS_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID_List(Params_Get_Order_details_By_TENANTS_ID_List i_Params_Get_Order_details_By_TENANTS_ID_List);
    Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID(Params_Get_Orders_By_CUSTOMERS_ID i_Params_Get_Orders_By_CUSTOMERS_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID_List(Params_Get_Orders_By_CUSTOMERS_ID_List i_Params_Get_Orders_By_CUSTOMERS_ID_List);
    Task<Orders> Get_Orders_By_ORDERS_ID(Params_Get_Orders_By_ORDERS_ID i_Params_Get_Orders_By_ORDERS_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_ORDERS_ID_List(Params_Get_Orders_By_ORDERS_ID_List i_Params_Get_Orders_By_ORDERS_ID_List);
    Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID(Params_Get_Orders_By_PROMO_CODES_ID i_Params_Get_Orders_By_PROMO_CODES_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID_List(Params_Get_Orders_By_PROMO_CODES_ID_List i_Params_Get_Orders_By_PROMO_CODES_ID_List);
    Task<Get_Orders_By_Properties_Response> Get_Orders_By_Properties(Params_Get_Orders_By_Properties i_Params_Get_Orders_By_Properties);
    Task<IEnumerable<Orders>> Get_Orders_By_TENANT_ID(Params_Get_Orders_By_TENANT_ID i_Params_Get_Orders_By_TENANT_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID(Params_Get_Orders_By_TENANTS_ID i_Params_Get_Orders_By_TENANTS_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID_List(Params_Get_Orders_By_TENANTS_ID_List i_Params_Get_Orders_By_TENANTS_ID_List);
    Task<Products> Get_Products_By_PRODUCTS_ID(Params_Get_Products_By_PRODUCTS_ID i_Params_Get_Products_By_PRODUCTS_ID);
    Task<IEnumerable<Products>> Get_Products_By_PRODUCTS_ID_List(Params_Get_Products_By_PRODUCTS_ID_List i_Params_Get_Products_By_PRODUCTS_ID_List);
    Task<Get_Products_By_Properties_Response> Get_Products_By_Properties(Params_Get_Products_By_Properties i_Params_Get_Products_By_Properties);
    Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID(Params_Get_Products_By_SHOPS_ID i_Params_Get_Products_By_SHOPS_ID);
    Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID_List(Params_Get_Products_By_SHOPS_ID_List i_Params_Get_Products_By_SHOPS_ID_List);
    Task<IEnumerable<Products>> Get_Products_By_TENANT_ID(Params_Get_Products_By_TENANT_ID i_Params_Get_Products_By_TENANT_ID);
    Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID(Params_Get_Products_By_TENANTS_ID i_Params_Get_Products_By_TENANTS_ID);
    Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID_List(Params_Get_Products_By_TENANTS_ID_List i_Params_Get_Products_By_TENANTS_ID_List);
    Task<Promo_codes> Get_Promo_codes_By_PROMO_CODES_ID(Params_Get_Promo_codes_By_PROMO_CODES_ID i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
    Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_PROMO_CODES_ID_List(Params_Get_Promo_codes_By_PROMO_CODES_ID_List i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
    Task<Get_Promo_codes_By_Properties_Response> Get_Promo_codes_By_Properties(Params_Get_Promo_codes_By_Properties i_Params_Get_Promo_codes_By_Properties);
    Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANT_ID(Params_Get_Promo_codes_By_TENANT_ID i_Params_Get_Promo_codes_By_TENANT_ID);
    Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANTS_ID(Params_Get_Promo_codes_By_TENANTS_ID i_Params_Get_Promo_codes_By_TENANTS_ID);
    Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANTS_ID_List(Params_Get_Promo_codes_By_TENANTS_ID_List i_Params_Get_Promo_codes_By_TENANTS_ID_List);
    Task<Get_Setup_By_Properties_Response> Get_Setup_By_Properties(Params_Get_Setup_By_Properties i_Params_Get_Setup_By_Properties);
    Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
    Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
    Task<Setup> Get_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
    Task<Setup> Get_Setup_By_SETUP_ID(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID);
    Task<IEnumerable<Setup>> Get_Setup_By_SETUP_ID_List(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List);
    Task<IEnumerable<Setup>> Get_Setup_By_TENANT_ID(Params_Get_Setup_By_TENANT_ID i_Params_Get_Setup_By_TENANT_ID);
    Task<Get_Setup_category_By_Properties_Response> Get_Setup_category_By_Properties(Params_Get_Setup_category_By_Properties i_Params_Get_Setup_category_By_Properties);
    Task<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
    Task<IEnumerable<Setup_category>> Get_Setup_category_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
    Task<IEnumerable<Setup_category>> Get_Setup_category_By_TENANT_ID(Params_Get_Setup_category_By_TENANT_ID i_Params_Get_Setup_category_By_TENANT_ID);
    Task<Get_Shops_By_Properties_Response> Get_Shops_By_Properties(Params_Get_Shops_By_Properties i_Params_Get_Shops_By_Properties);
    Task<Shops> Get_Shops_By_SHOPS_ID(Params_Get_Shops_By_SHOPS_ID i_Params_Get_Shops_By_SHOPS_ID);
    Task<IEnumerable<Shops>> Get_Shops_By_SHOPS_ID_List(Params_Get_Shops_By_SHOPS_ID_List i_Params_Get_Shops_By_SHOPS_ID_List);
    Task<IEnumerable<Shops>> Get_Shops_By_TENANT_ID(Params_Get_Shops_By_TENANT_ID i_Params_Get_Shops_By_TENANT_ID);
    Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID(Params_Get_Shops_By_TENANTS_ID i_Params_Get_Shops_By_TENANTS_ID);
    Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID_List(Params_Get_Shops_By_TENANTS_ID_List i_Params_Get_Shops_By_TENANTS_ID_List);
    Task<IEnumerable<Tenant>> Get_Tenant_By_IS_DELETED(Params_Get_Tenant_By_IS_DELETED i_Params_Get_Tenant_By_IS_DELETED);
    Task<Get_Tenant_By_Properties_Response> Get_Tenant_By_Properties(Params_Get_Tenant_By_Properties i_Params_Get_Tenant_By_Properties);
    Task<Tenant> Get_Tenant_By_TENANT_ID(Params_Get_Tenant_By_TENANT_ID i_Params_Get_Tenant_By_TENANT_ID);
    Task<IEnumerable<Tenant>> Get_Tenant_By_TENANT_ID_List(Params_Get_Tenant_By_TENANT_ID_List i_Params_Get_Tenant_By_TENANT_ID_List);
    Task<Get_Tenants_By_Properties_Response> Get_Tenants_By_Properties(Params_Get_Tenants_By_Properties i_Params_Get_Tenants_By_Properties);
    Task<IEnumerable<Tenants>> Get_Tenants_By_TENANT_ID(Params_Get_Tenants_By_TENANT_ID i_Params_Get_Tenants_By_TENANT_ID);
    Task<Tenants> Get_Tenants_By_TENANTS_ID(Params_Get_Tenants_By_TENANTS_ID i_Params_Get_Tenants_By_TENANTS_ID);
    Task<IEnumerable<Tenants>> Get_Tenants_By_TENANTS_ID_List(Params_Get_Tenants_By_TENANTS_ID_List i_Params_Get_Tenants_By_TENANTS_ID_List);
    Task<User> Get_User_By_EMAIL_TENANT_ID(Params_Get_User_By_EMAIL_TENANT_ID i_Params_Get_User_By_EMAIL_TENANT_ID);
    Task<Get_User_By_Properties_Response> Get_User_By_Properties(Params_Get_User_By_Properties i_Params_Get_User_By_Properties);
    Task<IEnumerable<User>> Get_User_By_TENANT_ID(Params_Get_User_By_TENANT_ID i_Params_Get_User_By_TENANT_ID);
    Task<IEnumerable<User>> Get_User_By_TENANT_ID_IS_DELETED(Params_Get_User_By_TENANT_ID_IS_DELETED i_Params_Get_User_By_TENANT_ID_IS_DELETED);
    Task<User> Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID);
    Task<IEnumerable<User>> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List);
    Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID);
    Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID_List(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
    Task<User> Get_User_By_USERNAME_TENANT_ID(Params_Get_User_By_USERNAME_TENANT_ID i_Params_Get_User_By_USERNAME_TENANT_ID);
}
