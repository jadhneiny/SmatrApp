using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Filters;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Common.Utilities;
using ShopeManagementApp.Application.Contracts;

namespace ShopeManagementApp.WebApi.Filters;

public class ContextResolverFilter : IAsyncActionFilter
{
    private readonly IBusinessService _businessService;
    private readonly ILogger<ContextResolverFilter> _logger;
    private readonly ApplicationSettings _applicationSettings;

    public ContextResolverFilter(
        IBusinessService i_BusinessService,
        ILogger<ContextResolverFilter> i_Logger,
        IOptions<ApplicationSettings> i_ApplicationSettings
    )
    {
        _businessService = i_BusinessService ?? throw new ArgumentNullException(nameof(i_BusinessService));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        try
        {
            await _businessService.GetAppContext(context);
            await next();
        }
        catch (UnauthorizedAccessException ex)
        {
            _logger.LogWarning(ex, "Unauthorized access attempt.");

            context.HttpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
            context.HttpContext.Response.ContentType = "application/json";

            var exceptionDetails = new
            {
                Exception_Message = ex.Message,
                Stack_Trace = _applicationSettings.ApplicationConfig.Is_Debug_Mode_Enabled ? ex.StackTrace : string.Empty
            };

            var exceptionJson = await exceptionDetails.SerializeAsync();
            await context.HttpContext.Response.WriteAsync(exceptionJson);
        }
    }
}
