using System;
using System.Threading.Tasks;
using Dojo.NetPlus.Api;
using Refit;

namespace Dojo.NetPlus.Services
{
    public abstract class BaseService
    {
        protected async Task<Response<T>> ExecuteApiCallAsync<T>(Func<Task<ApiResponse<T>>> apiCall) where T : IResponseType
        {
            try
            {
                var result = await apiCall();
                return new Response<T>(result);
            }
            catch (ApiException apiException)
            {
                return new Response<T>(apiException);
            }
            catch (Exception e)
            {
                return new Response<T>(e.Message);
            }
        }
    }
}