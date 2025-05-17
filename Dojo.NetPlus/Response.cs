using Dojo.NetPlus.Api;
using Refit;

namespace Dojo.NetPlus
{
    public class Response<T> where T : IResponseType
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
        public DojoApiError DojoError { get; set; }
        public string Message { get; set; }

        public Response()
        {
            
        }

        public Response(ApiResponse<T> apiResponse)
        {
            Success = apiResponse.IsSuccessStatusCode;
            StatusCode = (int)apiResponse.StatusCode;
            Data = apiResponse.Content;
            DojoError = apiResponse.Error.GetApiError();
        }

        public Response(string errorMessage)
        {
            
            errorMessage = $"An error occurred while contacting the Dojo API: {errorMessage}";
            
            Success = false;
            StatusCode = 500;
            Data = default;
            DojoError = new DojoApiError
            {
                Detail = errorMessage
            };
            Message = errorMessage;
        }
        
        
    }
}