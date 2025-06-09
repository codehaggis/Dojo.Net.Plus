using System.Text.Json;
using System.Text.Json.Serialization;
using Dojo.Net.Plus.Api;
using Refit;

namespace Dojo.Net.Plus
{
    public static class ApiResponseExtensions
    {

        public static DojoApiError GetApiError(this ApiException apiException)
        {

            try
            {
                if (!string.IsNullOrEmpty(apiException.Content))
                {
                    // try to deserialize the error

                    var options = new JsonSerializerOptions
                    {
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                        Converters = { new JsonStringEnumConverter() },
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true,
                        NumberHandling = JsonNumberHandling.AllowReadingFromString,
                        PropertyNameCaseInsensitive = true,
                        UnmappedMemberHandling = JsonUnmappedMemberHandling.Skip
                    };
                    
                    var error = JsonSerializer.Deserialize<DojoApiError>(apiException.Content, options);
                    if (error != null)
                    {
                        return error;
                    }
                }
            }
            catch
            {
                // suppress
            }

            // if we can't deserialize the error, return a generic error
            return new DojoApiError();
        }
        
        
    }
}