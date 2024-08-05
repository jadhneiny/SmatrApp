namespace ShopeManagementApp.Domain.Entities;

public partial class Params_Get_Addresses_By_ADDRESSES_ID
{
    public int ADDRESSES_ID { get; set; }
}
public partial class Params_Get_Addresses_By_ADDRESSES_ID_List
{
    public IEnumerable<int> ADDRESSES_ID_LIST { get; set; }
}
public partial class Params_Get_Addresses_By_CUSTOMERS_ID
{
    public int? CUSTOMERS_ID { get; set; }
}
public partial class Params_Get_Addresses_By_CUSTOMERS_ID_List
{
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
}
public partial class Params_Get_Addresses_By_Properties
{
    public int? ADDRESSES_ID { get; set; }
    public IEnumerable<int?> ADDRESSES_ID_LIST { get; set; }
    public int? CUSTOMERS_ID { get; set; }
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
    public string STREET { get; set; }
    public string CITY { get; set; }
    public string STATE { get; set; }
    public string ZIP_CODE { get; set; }
    public string COUNTRY { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Addresses_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Admins_By_ADMINS_ID
{
    public int ADMINS_ID { get; set; }
}
public partial class Params_Get_Admins_By_ADMINS_ID_List
{
    public IEnumerable<int> ADMINS_ID_LIST { get; set; }
}
public partial class Params_Get_Admins_By_Properties
{
    public int? ADMINS_ID { get; set; }
    public IEnumerable<int?> ADMINS_ID_LIST { get; set; }
    public string NAME { get; set; }
    public string USERNAME { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public DateTime? CREATED_AT_START { get; set; }
    public DateTime? CREATED_AT_END { get; set; }
    public bool? CREATED_AT_INCLUSIVE { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Admins_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Admins_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Admins_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Customers_By_CUSTOMERS_ID
{
    public int CUSTOMERS_ID { get; set; }
}
public partial class Params_Get_Customers_By_CUSTOMERS_ID_List
{
    public IEnumerable<int> CUSTOMERS_ID_LIST { get; set; }
}
public partial class Params_Get_Customers_By_Properties
{
    public int? CUSTOMERS_ID { get; set; }
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
    public string NAME { get; set; }
    public string USERNAME { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public DateTime? CREATED_AT_START { get; set; }
    public DateTime? CREATED_AT_END { get; set; }
    public bool? CREATED_AT_INCLUSIVE { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Customers_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Customers_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Customers_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Order_details_By_ORDER_DETAILS_ID
{
    public int ORDER_DETAILS_ID { get; set; }
}
public partial class Params_Get_Order_details_By_ORDER_DETAILS_ID_List
{
    public IEnumerable<int> ORDER_DETAILS_ID_LIST { get; set; }
}
public partial class Params_Get_Order_details_By_ORDERS_ID
{
    public int? ORDERS_ID { get; set; }
}
public partial class Params_Get_Order_details_By_ORDERS_ID_List
{
    public IEnumerable<int?> ORDERS_ID_LIST { get; set; }
}
public partial class Params_Get_Order_details_By_PRODUCTS_ID
{
    public int? PRODUCTS_ID { get; set; }
}
public partial class Params_Get_Order_details_By_PRODUCTS_ID_List
{
    public IEnumerable<int?> PRODUCTS_ID_LIST { get; set; }
}
public partial class Params_Get_Order_details_By_Properties
{
    public int? ORDER_DETAILS_ID { get; set; }
    public IEnumerable<int?> ORDER_DETAILS_ID_LIST { get; set; }
    public int? ORDERS_ID { get; set; }
    public IEnumerable<int?> ORDERS_ID_LIST { get; set; }
    public int? PRODUCTS_ID { get; set; }
    public IEnumerable<int?> PRODUCTS_ID_LIST { get; set; }
    public int? QUANTITY { get; set; }
    public decimal? PRICE { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public string DESCRIPTION { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Order_details_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Order_details_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Order_details_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Orders_By_CUSTOMERS_ID
{
    public int? CUSTOMERS_ID { get; set; }
}
public partial class Params_Get_Orders_By_CUSTOMERS_ID_List
{
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
}
public partial class Params_Get_Orders_By_ORDERS_ID
{
    public int ORDERS_ID { get; set; }
}
public partial class Params_Get_Orders_By_ORDERS_ID_List
{
    public IEnumerable<int> ORDERS_ID_LIST { get; set; }
}
public partial class Params_Get_Orders_By_PROMO_CODES_ID
{
    public int? PROMO_CODES_ID { get; set; }
}
public partial class Params_Get_Orders_By_PROMO_CODES_ID_List
{
    public IEnumerable<int?> PROMO_CODES_ID_LIST { get; set; }
}
public partial class Params_Get_Orders_By_Properties
{
    public int? ORDERS_ID { get; set; }
    public IEnumerable<int?> ORDERS_ID_LIST { get; set; }
    public int? CUSTOMERS_ID { get; set; }
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
    public DateTime? ORDER_DATE { get; set; }
    public DateTime? ORDER_DATE_START { get; set; }
    public DateTime? ORDER_DATE_END { get; set; }
    public bool? ORDER_DATE_INCLUSIVE { get; set; }
    public string STATUS { get; set; }
    public int? PROMO_CODES_ID { get; set; }
    public IEnumerable<int?> PROMO_CODES_ID_LIST { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Orders_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Orders_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Orders_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Products_By_PRODUCTS_ID
{
    public int PRODUCTS_ID { get; set; }
}
public partial class Params_Get_Products_By_PRODUCTS_ID_List
{
    public IEnumerable<int> PRODUCTS_ID_LIST { get; set; }
}
public partial class Params_Get_Products_By_Properties
{
    public int? PRODUCTS_ID { get; set; }
    public IEnumerable<int?> PRODUCTS_ID_LIST { get; set; }
    public int? SHOPS_ID { get; set; }
    public IEnumerable<int?> SHOPS_ID_LIST { get; set; }
    public string PRODUCT_NAME { get; set; }
    public decimal? PRICE { get; set; }
    public string IMAGE { get; set; }
    public string DESCRIPTION { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Products_By_SHOPS_ID
{
    public int? SHOPS_ID { get; set; }
}
public partial class Params_Get_Products_By_SHOPS_ID_List
{
    public IEnumerable<int?> SHOPS_ID_LIST { get; set; }
}
public partial class Params_Get_Products_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Products_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Products_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Promo_codes_By_PROMO_CODES_ID
{
    public int PROMO_CODES_ID { get; set; }
}
public partial class Params_Get_Promo_codes_By_PROMO_CODES_ID_List
{
    public IEnumerable<int> PROMO_CODES_ID_LIST { get; set; }
}
public partial class Params_Get_Promo_codes_By_Properties
{
    public int? PROMO_CODES_ID { get; set; }
    public IEnumerable<int?> PROMO_CODES_ID_LIST { get; set; }
    public string CODE { get; set; }
    public decimal? DISCOUNT { get; set; }
    public DateTime? EXPIRATION_DATE { get; set; }
    public DateTime? EXPIRATION_DATE_START { get; set; }
    public DateTime? EXPIRATION_DATE_END { get; set; }
    public bool? EXPIRATION_DATE_INCLUSIVE { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Promo_codes_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Promo_codes_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Promo_codes_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Setup_By_Properties
{
    public long? SETUP_ID { get; set; }
    public IEnumerable<long?> SETUP_ID_LIST { get; set; }
    public int? SETUP_CATEGORY_ID { get; set; }
    public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
    public bool? IS_SYSTEM { get; set; }
    public bool? IS_DELETEABLE { get; set; }
    public bool? IS_UPDATEABLE { get; set; }
    public bool? IS_DELETED { get; set; }
    public bool? IS_VISIBLE { get; set; }
    public int? DISPLAY_ORDER { get; set; }
    public string VALUE { get; set; }
    public string DESCRIPTION { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public long? OFFSET { get; set; }
    public long? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID
{
    public int SETUP_CATEGORY_ID { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_List
{
    public IEnumerable<int> SETUP_CATEGORY_ID_LIST { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
{
    public int SETUP_CATEGORY_ID { get; set; }
    public string VALUE { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_ID
{
    public long SETUP_ID { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_ID_List
{
    public IEnumerable<long> SETUP_ID_LIST { get; set; }
}
public partial class Params_Get_Setup_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Setup_category_By_Properties
{
    public int? SETUP_CATEGORY_ID { get; set; }
    public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
    public string SETUP_CATEGORY_NAME { get; set; }
    public string DESCRIPTION { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID
{
    public int SETUP_CATEGORY_ID { get; set; }
}
public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List
{
    public IEnumerable<int> SETUP_CATEGORY_ID_LIST { get; set; }
}
public partial class Params_Get_Setup_category_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Shops_By_Properties
{
    public int? SHOPS_ID { get; set; }
    public IEnumerable<int?> SHOPS_ID_LIST { get; set; }
    public string NAME { get; set; }
    public string CURRENCY { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Shops_By_SHOPS_ID
{
    public int SHOPS_ID { get; set; }
}
public partial class Params_Get_Shops_By_SHOPS_ID_List
{
    public IEnumerable<int> SHOPS_ID_LIST { get; set; }
}
public partial class Params_Get_Shops_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Shops_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Shops_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Tenant_By_IS_DELETED
{
    public bool IS_DELETED { get; set; }
}
public partial class Params_Get_Tenant_By_Properties
{
    public int TENANT_ID { get; set; }
    public string TENANT_NAME { get; set; }
    public string TENANT_CODE { get; set; }
    public bool? IS_SUPER_TENANT { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public string DESCRIPTION { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public bool? IS_DELETED { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Tenant_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Tenant_By_TENANT_ID_List
{
    public IEnumerable<int> TENANT_ID_LIST { get; set; }
}
public partial class Params_Get_Tenants_By_Properties
{
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public string NAME { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public DateTime? CREATED_AT_START { get; set; }
    public DateTime? CREATED_AT_END { get; set; }
    public bool? CREATED_AT_INCLUSIVE { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Tenants_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Tenants_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Tenants_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_User_By_EMAIL_TENANT_ID
{
    public string EMAIL { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_User_By_Properties
{
    public long? USER_ID { get; set; }
    public IEnumerable<long?> USER_ID_LIST { get; set; }
    public long? USER_TYPE_SETUP_ID { get; set; }
    public IEnumerable<long?> USER_TYPE_SETUP_ID_LIST { get; set; }
    public string FULL_NAME { get; set; }
    public string EMAIL { get; set; }
    public string USERNAME { get; set; }
    public string PASSWORD { get; set; }
    public bool? IS_ACTIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public int TENANT_ID { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public long? OFFSET { get; set; }
    public long? FETCH_NEXT { get; set; }
}
public partial class Params_Get_User_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_User_By_TENANT_ID_IS_DELETED
{
    public int TENANT_ID { get; set; }
    public bool IS_DELETED { get; set; }
}
public partial class Params_Get_User_By_USER_ID
{
    public long USER_ID { get; set; }
}
public partial class Params_Get_User_By_USER_ID_List
{
    public IEnumerable<long> USER_ID_LIST { get; set; }
}
public partial class Params_Get_User_By_USER_TYPE_SETUP_ID
{
    public long USER_TYPE_SETUP_ID { get; set; }
}
public partial class Params_Get_User_By_USER_TYPE_SETUP_ID_List
{
    public IEnumerable<long> USER_TYPE_SETUP_ID_LIST { get; set; }
}
public partial class Params_Get_User_By_USERNAME_TENANT_ID
{
    public string USERNAME { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Addresses
{
    public int ADDRESSES_ID { get; set; }
}
public partial class Params_Delete_Addresses_By_CUSTOMERS_ID
{
    public int? CUSTOMERS_ID { get; set; }
}
public partial class Params_Delete_Addresses_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_Addresses_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Addresses> List_To_Edit { get; set; }
    public IEnumerable<Addresses> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Admins
{
    public int ADMINS_ID { get; set; }
}
public partial class Params_Delete_Admins_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Admins_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Admins_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Admins> List_To_Edit { get; set; }
    public IEnumerable<Admins> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Customers
{
    public int CUSTOMERS_ID { get; set; }
}
public partial class Params_Delete_Customers_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Customers_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Customers_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Customers> List_To_Edit { get; set; }
    public IEnumerable<Customers> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Order_details
{
    public int ORDER_DETAILS_ID { get; set; }
}
public partial class Params_Delete_Order_details_By_ORDERS_ID
{
    public int? ORDERS_ID { get; set; }
}
public partial class Params_Delete_Order_details_By_PRODUCTS_ID
{
    public int? PRODUCTS_ID { get; set; }
}
public partial class Params_Delete_Order_details_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Order_details_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Order_details_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Order_details> List_To_Edit { get; set; }
    public IEnumerable<Order_details> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Orders
{
    public int ORDERS_ID { get; set; }
}
public partial class Params_Delete_Orders_By_CUSTOMERS_ID
{
    public int? CUSTOMERS_ID { get; set; }
}
public partial class Params_Delete_Orders_By_PROMO_CODES_ID
{
    public int? PROMO_CODES_ID { get; set; }
}
public partial class Params_Delete_Orders_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Orders_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Orders_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Orders> List_To_Edit { get; set; }
    public IEnumerable<Orders> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Products
{
    public int PRODUCTS_ID { get; set; }
}
public partial class Params_Delete_Products_By_SHOPS_ID
{
    public int? SHOPS_ID { get; set; }
}
public partial class Params_Delete_Products_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Products_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Products_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Products> List_To_Edit { get; set; }
    public IEnumerable<Products> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Promo_codes
{
    public int PROMO_CODES_ID { get; set; }
}
public partial class Params_Delete_Promo_codes_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Promo_codes_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Promo_codes_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Promo_codes> List_To_Edit { get; set; }
    public IEnumerable<Promo_codes> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Setup
{
    public long SETUP_ID { get; set; }
}
public partial class Params_Delete_Setup_By_SETUP_CATEGORY_ID
{
    public int SETUP_CATEGORY_ID { get; set; }
}
public partial class Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
{
    public int SETUP_CATEGORY_ID { get; set; }
    public string VALUE { get; set; }
}
public partial class Params_Delete_Setup_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_Setup_List
{
    public IEnumerable<long> List_To_Delete { get; set; }
    public IEnumerable<long> List_Failed_Delete { get; set; }
    public IEnumerable<Setup> List_To_Edit { get; set; }
    public IEnumerable<Setup> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Setup_category
{
    public int SETUP_CATEGORY_ID { get; set; }
}
public partial class Params_Delete_Setup_category_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_Setup_category_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Setup_category> List_To_Edit { get; set; }
    public IEnumerable<Setup_category> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Shops
{
    public int SHOPS_ID { get; set; }
}
public partial class Params_Delete_Shops_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Shops_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Shops_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Shops> List_To_Edit { get; set; }
    public IEnumerable<Shops> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Tenant
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Tenant_By_IS_DELETED
{
    public bool IS_DELETED { get; set; }
}
public partial class Params_Edit_Tenant_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Tenant> List_To_Edit { get; set; }
    public IEnumerable<Tenant> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Tenants
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Delete_Tenants_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_Tenants_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Tenants> List_To_Edit { get; set; }
    public IEnumerable<Tenants> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_User
{
    public long USER_ID { get; set; }
}
public partial class Params_Delete_User_By_EMAIL_TENANT_ID
{
    public string EMAIL { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_User_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_User_By_TENANT_ID_IS_DELETED
{
    public int TENANT_ID { get; set; }
    public bool IS_DELETED { get; set; }
}
public partial class Params_Delete_User_By_USER_TYPE_SETUP_ID
{
    public long USER_TYPE_SETUP_ID { get; set; }
}
public partial class Params_Delete_User_By_USERNAME_TENANT_ID
{
    public string USERNAME { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_User_List
{
    public IEnumerable<long> List_To_Delete { get; set; }
    public IEnumerable<long> List_Failed_Delete { get; set; }
    public IEnumerable<User> List_To_Edit { get; set; }
    public IEnumerable<User> List_Failed_Edit { get; set; }
}
