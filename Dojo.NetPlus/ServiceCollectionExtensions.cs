using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Dojo.NetPlus.Api;
using Dojo.NetPlus.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;
using Refit;

namespace Dojo.NetPlus
{
    public static class ServiceCollectionExtensions
    {
        
        public static IServiceCollection AddDojoNetPlus(this IServiceCollection services, string apiKey,
            Action<Options> configureOptions = null)
        {
            
            // configure options
            var options = new Options();
            configureOptions?.Invoke(options);

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException("API key must be provided.", nameof(apiKey));
            }

            if (options.OutputResponseBodyToConsole)
            {
                services.AddLogging(builder =>
                {
                    builder.AddConsole(); // Enable console logging
                    builder.SetMinimumLevel(LogLevel.Information);  // Set minimum log level
                    services.AddTransient<LoggingHandler>();
                });
            }
            
            
            
            // register refit client
            var refitBuilder = services.AddRefitClient<IDojoApi>(new RefitSettings
                {
                    ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions
                    {
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                        Converters = { new JsonStringEnumConverter() },
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true,
                        NumberHandling = JsonNumberHandling.AllowReadingFromString,
                        PropertyNameCaseInsensitive = true,
                        UnmappedMemberHandling = JsonUnmappedMemberHandling.Skip
                    })
                })
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri(options.BaseUrl);
                    c.DefaultRequestHeaders.Add("Authorization", $"Basic {apiKey}");
                    c.DefaultRequestHeaders.Add("version", options.Version);
                    
                    if (options.ResellerId != null) c.DefaultRequestHeaders.Add("reseller-id", options.ResellerId);
                    if (options.SoftwareHouseId != null) c.DefaultRequestHeaders.Add("software-house-id", options.SoftwareHouseId);
                    
                })
                .AddTransientHttpErrorPolicy(x => x.WaitAndRetryAsync(1, retryAttempt => TimeSpan.FromSeconds(Math.Pow(options.RetryCount, retryAttempt))));

            if (options.OutputResponseBodyToConsole)
            {
                refitBuilder.AddHttpMessageHandler<LoggingHandler>();
            }
            
            // register services
            services.AddTransient<IDojoPaymentIntentService, DojoPaymentIntentService>();
            services.AddTransient<IDojoTerminalService, DojoTerminalService>();
            services.AddTransient<IDojoRefundService, DojoRefundService>();

            return services;

        }
    }
}
