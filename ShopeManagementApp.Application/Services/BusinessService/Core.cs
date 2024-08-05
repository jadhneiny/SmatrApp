using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Filters;
using ShopeManagementApp.Domain.Entities;

namespace ShopeManagementApp.Application.Services;

public partial class BusinessService
{
    public async Task<User> Get_Current_User()
    {
        _userSessionContext.Bypass_RLS = true;
        await _databaseContext.SetContext();
        var oUser = await Get_User_By_USER_ID(new()
        {
            USER_ID = _userSessionContext.User_ID
        });
        _userSessionContext.Bypass_RLS = false;
        _userSessionContext.Tenant_ID = oUser.TENANT_ID;
        await _databaseContext.SetContext();

        return oUser;
    }
    public async Task GetAppContext(long i_UserID)
    {
        await GetAppContext(i_UserID.ToString());
    }
    public async Task GetAppContext(string i_Subject)
    {
        _userSessionContext.ResolveContextSubject(i_Subject);
        await Get_Current_User();
    }
    public async Task GetAppContext(ActionExecutingContext context)
    {
        var oSubject = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (oSubject != null)
        {
            string[] oSubject_Parts = oSubject.Split(_applicationSettings.ApplicationConfig.Cipher_Separator);
            if (oSubject_Parts.Length < 2)
            {
                throw new FormatException("Subject is not in the expected format.");
            }
            await GetAppContext(oSubject_Parts[0]);
        }
        else
        {
            throw new FormatException("Unauthorized request.");
        }
    }
    private void PostConstruct()
    {
    }
}
