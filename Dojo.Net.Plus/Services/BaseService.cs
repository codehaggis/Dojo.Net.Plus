using System;
using System.Threading.Tasks;
using Dojo.Net.Plus.Api;
using Refit;

namespace Dojo.Net.Plus.Services
{
    public abstract class BaseService
    {
        protected async Task<DojoResponse<T>> ExecuteApiCallAsync<T>(Func<Task<ApiResponse<T>>> apiCall) where T : IResponseType
        {
            try
            {
                var result = await apiCall();
                return new DojoResponse<T>(result);
            }
            catch (Exception e)
            {
                return new DojoResponse<T>(e.Message);
            }
        }
    }
}