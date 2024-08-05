using Microsoft.Extensions.DependencyInjection;

namespace ShopeManagementApp.Common.Services;

public static partial class ServiceLocator
{
    private static IServiceScope _serviceScope;
    public static IServiceScope ServiceScopeInstance
    {
        get
        {
            _serviceScope ??= ServiceProvider.CreateScope();
            return _serviceScope;
        }
        set
        {
            _serviceScope = value;
        }
    }
    public static IServiceProvider ServiceProvider { get; set; }
    public static T GetService<T>(bool Is_Use_Global_Scope = false)
    {
        if (Is_Use_Global_Scope)
        {
            return ServiceScopeInstance.ServiceProvider.GetService<T>();
        }
        else
        {
            using var scope = ServiceProvider.CreateScope();
            return scope.ServiceProvider.GetService<T>();
        }
    }
}
