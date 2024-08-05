using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Common.Exceptions;
using ShopeManagementApp.Common.Contracts;

namespace ShopeManagementApp.Common.UserSession;

public partial class UserSessionContext : IUserSessionContext
{
    public long User_ID { get; set; }
    public int Tenant_ID { get; set; }
    public bool Bypass_RLS { get; set; }
    public Enum_Language Language { get; set; }

    public void ResolveContextSubject(string i_Subject)
    {
        if (!long.TryParse(i_Subject, out long oUser_ID))
        {
            throw new PlatformException(Enum_Message_Code.UserIdParseError);
        }

        User_ID = oUser_ID;
    }
}
