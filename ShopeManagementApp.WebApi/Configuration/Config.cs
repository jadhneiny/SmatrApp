using Serilog;
using ShopeManagementApp.Application.Contracts;
using ShopeManagementApp.Application.Services;
using ShopeManagementApp.Common.Contracts;
using ShopeManagementApp.Common.Services;
using ShopeManagementApp.Common.UserSession;
using ShopeManagementApp.CrossCuttingConcerns.Logging;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Infrastructure.Contracts;
using ShopeManagementApp.Infrastructure.Data;
using ShopeManagementApp.Infrastructure.Repositories;
using ShopeManagementApp.WebApi.Filters;

namespace ShopeManagementApp.WebApi.Configuration;

public static partial class ServiceConfiguration
{
    public static IServiceCollection AddServices(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddScoped<IMessageService, MessageService>();
        services.Configure<ApplicationSettings>(builder.Configuration);
        services.AddSingleton<SerilogConfiguration>();
        if (builder.Configuration["Logging:LogLevel:Default"] != "None")
        {
            builder.Host.UseSerilog((context, config) =>
            {
                var serilogConfig = builder.Services.BuildServiceProvider().GetService<SerilogConfiguration>();
                serilogConfig?.Configure(context, config);
            });
        }
        services.AddScoped<IDatabaseContext, DatabaseContext>();
        services.AddScoped<IUserSessionContext, UserSessionContext>();

        services.AddScoped<IBusinessService, BusinessService>();
        services.AddTransient<IBusinessRepository, BusinessRepository>();

        services.AddControllers(options =>
        {
            options.Filters.Add<ContextResolverFilter>();
        });

        return services;
    }
}
