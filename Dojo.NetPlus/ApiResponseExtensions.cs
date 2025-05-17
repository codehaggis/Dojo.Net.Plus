using Dojo.NetPlus.Api;
using System.Text.Json;
using Refit;

namespace Dojo.NetPlus
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
                    var error = JsonSerializer.Deserialize<DojoApiError>(apiException.Content);
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