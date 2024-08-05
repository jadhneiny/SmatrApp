using System.Net;
using Microsoft.Extensions.Options;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Common.Utilities;
using ShopeManagementApp.Common.Exceptions;

namespace ShopeManagementApp.WebApi.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ApplicationSettings _applicationSettings;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(
        RequestDelegate next,
        ILogger<ExceptionHandlingMiddleware> i_Logger,
        IOptions<ApplicationSettings> i_ApplicationSettings
    )
    {
        _next = next ?? throw new ArgumentNullException(nameof(next));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unhandled exception has occurred.");
            await HandleExceptionAsync(context, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = exception is PlatformException ? (int)HttpStatusCode.BadRequest : (int)HttpStatusCode.InternalServerError;

        var exception_response = new
        {
            Exception_Message = (exception is PlatformException || _applicationSettings.ApplicationConfig.Is_Debug_Mode_Enabled) ? exception.Message : _applicationSettings.ApplicationConfig.UnexpectedErrorMessage,
            Stack_Trace = _applicationSettings.ApplicationConfig.Is_Debug_Mode_Enabled ? exception.StackTrace : string.Empty
        };

        return context.Response.WriteAsync(exception_response.Serialize());
    }
}
