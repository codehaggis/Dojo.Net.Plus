using Dojo.Net.Plus.Api;
using Refit;

namespace Dojo.Net.Plus
{
    public class DojoResponse<T> where T : IResponseType
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public T ResponseObject { get; set; }
        public DojoApiError DojoError { get; set; }
        public string Message { get; set; }

        public DojoResponse(ApiResponse<T> apiResponse)
        {
            Success = apiResponse.IsSuccessStatusCode;
            StatusCode = (int)apiResponse.StatusCode;
            ResponseObject = apiResponse.Content;
            DojoError = apiResponse.Error.GetApiError();
        }

        public DojoResponse(string errorMessage)
        {
            
            errorMessage = $"An error occurred while contacting the Dojo API: {errorMessage}";
            
            Success = false;
            StatusCode = 500;
            ResponseObject = default;
            DojoError = new DojoApiError
            {
                Detail = errorMessage
            };
            Message = errorMessage;
        }
        
        
    }
}