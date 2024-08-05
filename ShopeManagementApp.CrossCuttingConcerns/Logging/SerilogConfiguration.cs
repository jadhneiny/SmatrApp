using Serilog;
using Serilog.Events;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using ShopeManagementApp.Domain.Entities;
using ShopeManagementApp.Common.Extensions;

namespace ShopeManagementApp.CrossCuttingConcerns.Logging;

public class SerilogConfigurationException : Exception
{
    public SerilogConfigurationException(string message) : base(message) { }
    public SerilogConfigurationException(string message, Exception innerException) : base(message, innerException) { }
}

public class SerilogConfiguration
{
    private readonly ApplicationSettings _applicationSettings;

    public SerilogConfiguration(
        IOptions<ApplicationSettings> i_ApplicationSettings
    )
    {
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
    }

    public Action<HostBuilderContext, LoggerConfiguration> Configure =>
        (hostBuilderContext, loggerConfiguration) =>
        {
            var elasticsearch_host = _applicationSettings.ElasticsearchSettings.Host?.Trim() ?? string.Empty;
            var application_name = _applicationSettings.ApplicationConfig.Application_Name?.Trim() ?? hostBuilderContext.HostingEnvironment.ApplicationName;

            if (elasticsearch_host.IsNullOrWhiteSpace())
            {
                throw new SerilogConfigurationException("ELASTICSEARCH_HOST configuration is missing.");
            }

            Uri esUri;
            try
            {
                esUri = new Uri(elasticsearch_host);
            }
            catch (UriFormatException ex)
            {
                throw new SerilogConfigurationException($"ELASTICSEARCH_HOST configuration value '{elasticsearch_host}' is not a valid Uri.", ex);
            }

            var logLevel = hostBuilderContext.Configuration.GetSection("Logging").GetSection("LogLevel").GetValue<string>("Default") ?? "Warning";
            LogEventLevel minimumLogLevel;
            try
            {
                minimumLogLevel = Enum.Parse<LogEventLevel>(logLevel);
            }
            catch (ArgumentException ex)
            {
                throw new SerilogConfigurationException($"Log level '{logLevel}' is not recognized.", ex);
            }

            loggerConfiguration
                .MinimumLevel.Is(minimumLogLevel)
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .WriteTo.Async(oLoggerSinkConfiguration => oLoggerSinkConfiguration.Debug())
                .WriteTo.Async(oLoggerSinkConfiguration => oLoggerSinkConfiguration.Console())
                .WriteTo.Async(oLoggerSinkConfiguration => oLoggerSinkConfiguration.Elasticsearch(
                    new(esUri)
                    {
                        NumberOfShards = _applicationSettings.ElasticsearchSettings.NumberOfShards,
                        NumberOfReplicas = _applicationSettings.ElasticsearchSettings.NumberOfReplicas,
                        BufferBaseFilename = _applicationSettings.ElasticsearchSettings.BufferBaseFilename,
                        AutoRegisterTemplate = _applicationSettings.ElasticsearchSettings.AutoRegisterTemplate,
                        BufferLogShippingInterval = TimeSpan.FromSeconds(_applicationSettings.ElasticsearchSettings.BufferLogShippingInterval),
                        IndexFormat = $"{application_name}-{_applicationSettings.ElasticsearchSettings.IndexFormatIdentifier}-{DateTime.UtcNow:yyyy-MM}"
                    }
                ))
                .Enrich.WithProperty("Application", application_name)
                .Enrich.WithProperty("Environment", hostBuilderContext.HostingEnvironment.EnvironmentName)
                .ReadFrom.Configuration(hostBuilderContext.Configuration);
        };
}
