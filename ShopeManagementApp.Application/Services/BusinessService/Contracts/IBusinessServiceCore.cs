using ShopeManagementApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShopeManagementApp.Application.Contracts;

public partial interface IBusinessService
{
    Task<User> Get_Current_User();
    Task GetAppContext(long i_UserID);
    Task GetAppContext(string i_Subject);
    Task GetAppContext(ActionExecutingContext context);
}
