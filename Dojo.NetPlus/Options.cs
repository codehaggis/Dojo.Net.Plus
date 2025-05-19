namespace Dojo.NetPlus
{
    public class Options
    {
        public string BaseUrl { get; set; } = "https://api.dojo.tech"; // default
        public string SoftwareHouseId { get; set; }
        public string ResellerId { get; set; }
        public string Version { get; set; } = "2024-02-05"; // default
        public int RetryCount { get; set; } = 3; // default
        
        public bool OutputResponseBodyToConsole { get; set; }
    }
}