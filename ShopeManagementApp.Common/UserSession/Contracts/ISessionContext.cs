using ShopeManagementApp.Domain.Entities;

namespace ShopeManagementApp.Common.Contracts;

public partial interface IUserSessionContext
{
    long User_ID { get; set; }
    int Tenant_ID { get; set; }
    bool Bypass_RLS { get; set; }
    Enum_Language Language { get; set; }

    void ResolveContextSubject(string i_Subject);
}
