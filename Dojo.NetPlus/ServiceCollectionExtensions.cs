using System;
using Dojo.NetPlus.Api;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Refit;

namespace Dojo.NetPlus
{
    public static class ServiceCollectionExtensions
    {
        
        public static IServiceCollection AddDojoNetPlus(this IServiceCollection services, string apiKey,
            Action<Options> configureOptions = null)
        {
            var options = new Options();
            configureOptions?.Invoke(options);

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException("API key must be provided.", nameof(apiKey));
            }
            
            services.AddRefitClient<IDojoApi>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri(options.BaseUrl);
                    c.DefaultRequestHeaders.Add("Authorization", $"Basic {apiKey}");
                    c.DefaultRequestHeaders.Add("version", options.Version);
                    
                    if (options.ResellerId != null) c.DefaultRequestHeaders.Add("reseller-id", options.ResellerId);
                    if (options.SoftwareHouseId != null) c.DefaultRequestHeaders.Add("software-house-id", options.SoftwareHouseId);
                    
                })
                .AddTransientHttpErrorPolicy(x => x.WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(options.RetryCount, retryAttempt))));


            return services;

        }
    }
}
