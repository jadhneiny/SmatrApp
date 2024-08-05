namespace ShopeManagementApp.Domain.Entities;

public partial class ApplicationSettings
{
    public ApplicationConfig ApplicationConfig { get; set; }
    public ElasticsearchSettings ElasticsearchSettings { get; set; }
}
public partial class ApplicationConfig
{
    public bool Is_Caching_Enabled { get; set; }
    public bool Is_Auditing_Enabled { get; set; }
    public bool Is_Debug_Mode_Enabled { get; set; }
    public bool Is_File_Uploading_Enabled { get; set; }
    public bool Is_Method_Monitoring_Enabled { get; set; }
    public bool Is_Data_Synchronization_Enabled { get; set; }
    public bool Is_Eager_Loading_OneToMany_Enabled { get; set; }
    public Uri Upload_File_Url { get; set; }
    public string Cipher_Separator { get; set; }
    public string Application_Name { get; set; }
    public string Upload_File_Location { get; set; }
    public string UnexpectedErrorMessage { get; set; }
    public string Void_Successful_Message { get; set; }
    public string Delete_Successful_Message { get; set; }
    public int DatabaseConnectionCommandTimeout { get; set; }
}
public partial class ElasticsearchSettings
{
    public string Host { get; set; }
    public int NumberOfShards { get; set; }
    public int NumberOfReplicas { get; set; }
    public bool AutoRegisterTemplate { get; set; }
    public string BufferBaseFilename { get; set; }
    public string IndexFormatIdentifier { get; set; }
    public int BufferLogShippingInterval { get; set; }
}
