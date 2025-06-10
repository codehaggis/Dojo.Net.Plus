using Dojo.Net.Plus.Api.Shared.Enums;

namespace Dojo.Net.Plus
{
    public class Options
    {
        /// <summary>
        /// Base Dojo Api Address, defaults to https://api.dojo.tech
        /// </summary>
        public string BaseUrl { get; set; } = "https://api.dojo.tech"; // default
        
        /// <summary>
        /// Required to use terminal api endpoints, can be set to anything, unless you've been supplied an ID by Dojo
        /// </summary>
        public string SoftwareHouseId { get; set; }
        /// <summary>
        /// Required for some endpoints, can be set to anything, unless you've been supplied an ID by Dojo
        /// </summary>
        public string ResellerId { get; set; }
        
        /// <summary>
        /// Dojo Api Version, defaults to 2024-02-05
        /// </summary>
        public string ApiVersion { get; set; } = "2024-02-05"; // default
        
        /// <summary>
        /// Polly retry attempts before failing
        /// </summary>
        public int RetryCount { get; set; } = 3; // default
        
        public CurrencyCode DefaultCurrencyCode { get; set; } = CurrencyCode.GBP; // default
        
        /// <summary>
        /// Outputs the response body when debugging
        /// </summary>
        public bool OutputResponseBodyToConsole { get; set; }
    }
}