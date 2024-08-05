using ShopeManagementApp.Domain.Attributes;

namespace ShopeManagementApp.Domain.Entities;

public partial class Addresses
{
    public int ADDRESSES_ID { get; set; }
    public int? CUSTOMERS_ID { get; set; }
    public string STREET { get; set; }
    public string CITY { get; set; }
    public string STATE { get; set; }
    public string ZIP_CODE { get; set; }
    public string COUNTRY { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Customers Customers { get; set; }
    #endregion
}
public partial class Get_Addresses_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Addresses> List_Addresses { get; set; }
}
public partial class Admins
{
    public int ADMINS_ID { get; set; }
    public string NAME { get; set; }
    public string USERNAME { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Admins_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Admins> List_Admins { get; set; }
}
public partial class Customers
{
    public int CUSTOMERS_ID { get; set; }
    public string NAME { get; set; }
    public string USERNAME { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Customers_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Customers> List_Customers { get; set; }
}
public partial class Order_details
{
    public int ORDER_DETAILS_ID { get; set; }
    public int? ORDERS_ID { get; set; }
    public int? PRODUCTS_ID { get; set; }
    public int? QUANTITY { get; set; }
    public decimal? PRICE { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public string DESCRIPTION { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Orders Orders { get; set; }
    [SQLIgnore]
    public Products Products { get; set; }
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Order_details_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Order_details> List_Order_details { get; set; }
}
public partial class Orders
{
    public int ORDERS_ID { get; set; }
    public int? CUSTOMERS_ID { get; set; }
    public DateTime? ORDER_DATE { get; set; }
    public string STATUS { get; set; }
    public int? PROMO_CODES_ID { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Customers Customers { get; set; }
    [SQLIgnore]
    public Promo_codes Promo_codes { get; set; }
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Orders_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Orders> List_Orders { get; set; }
}
public partial class Products
{
    public int PRODUCTS_ID { get; set; }
    public int? SHOPS_ID { get; set; }
    public string PRODUCT_NAME { get; set; }
    public decimal PRICE { get; set; }
    public string IMAGE { get; set; }
    public string DESCRIPTION { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Shops Shops { get; set; }
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Products_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Products> List_Products { get; set; }
}
public partial class Promo_codes
{
    public int PROMO_CODES_ID { get; set; }
    public string CODE { get; set; }
    public decimal DISCOUNT { get; set; }
    public DateTime EXPIRATION_DATE { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Promo_codes_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Promo_codes> List_Promo_codes { get; set; }
}
public partial class Setup
{
    public long SETUP_ID { get; set; }
    public int SETUP_CATEGORY_ID { get; set; }
    public bool IS_SYSTEM { get; set; }
    public bool IS_DELETEABLE { get; set; }
    public bool IS_UPDATEABLE { get; set; }
    public bool IS_DELETED { get; set; }
    public bool IS_VISIBLE { get; set; }
    public int DISPLAY_ORDER { get; set; }
    public string VALUE { get; set; }
    public string DESCRIPTION { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Setup_category Setup_category { get; set; }
    #endregion
}
public partial class Get_Setup_By_Properties_Response
{
    public long? TOTAL_COUNT { get; set; }
    public IEnumerable<Setup> List_Setup { get; set; }
}
public partial class Setup_category
{
    public int SETUP_CATEGORY_ID { get; set; }
    public string SETUP_CATEGORY_NAME { get; set; }
    public string DESCRIPTION { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Get_Setup_category_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Setup_category> List_Setup_category { get; set; }
}
public partial class Shops
{
    public int SHOPS_ID { get; set; }
    public string NAME { get; set; }
    public string CURRENCY { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Shops_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Shops> List_Shops { get; set; }
}
public partial class Tenant
{
    public int TENANT_ID { get; set; }
    public string TENANT_NAME { get; set; }
    public string TENANT_CODE { get; set; }
    public bool IS_SUPER_TENANT { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public string DESCRIPTION { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public bool IS_DELETED { get; set; }
}
public partial class Get_Tenant_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Tenant> List_Tenant { get; set; }
}
public partial class Tenants
{
    public int TENANTS_ID { get; set; }
    public string NAME { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Get_Tenants_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Tenants> List_Tenants { get; set; }
}
public partial class User
{
    public long USER_ID { get; set; }
    public long USER_TYPE_SETUP_ID { get; set; }
    public string FULL_NAME { get; set; }
    public string EMAIL { get; set; }
    public string USERNAME { get; set; }
    public string PASSWORD { get; set; }
    public bool IS_ACTIVE { get; set; }
    public bool IS_DELETED { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public int TENANT_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Setup User_type_setup { get; set; }
    #endregion
}
public partial class Get_User_By_Properties_Response
{
    public long? TOTAL_COUNT { get; set; }
    public IEnumerable<User> List_User { get; set; }
}
