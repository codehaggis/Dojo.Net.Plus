using System;
using System.Threading.Tasks;
using Dojo.Net.Plus.Api;
using Dojo.Net.Plus.Api.Refunds;

namespace Dojo.Net.Plus.Services
{
    internal sealed class DojoRefundService : BaseService, IDojoRefundService
    {
        private readonly IDojoApi _dojoApi;

        public DojoRefundService(IDojoApi dojoApi)
        {
            _dojoApi = dojoApi;
        }

        public async Task<DojoResponse<RefundResponse>> CreateRefundAsync(string paymentIntentId, Guid idempotencyKey,
            CreateRefund createRefund)
        {
            
            return await ExecuteApiCallAsync(() => 
                _dojoApi.RefundPaymentIntent(idempotencyKey.ToString("N"), paymentIntentId, createRefund));
            
        }

        public async Task<DojoResponse<RefundResponse>> GetRefundAsync(string refundId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.GetRefund(refundId));
        }

        public async Task<DojoResponse<ReversalResponse>> ReversePaymentIntentAsync(string paymentIntentId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.ReversalPaymentIntent(paymentIntentId));
        }
    }
}