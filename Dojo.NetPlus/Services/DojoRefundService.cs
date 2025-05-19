using System;
using System.Threading.Tasks;
using Dojo.NetPlus.Api;
using Dojo.NetPlus.Api.Refunds;

namespace Dojo.NetPlus.Services
{
    internal sealed class DojoRefundService : BaseService, IDojoRefundService
    {
        private readonly IDojoApi _dojoApi;

        public DojoRefundService(IDojoApi dojoApi)
        {
            _dojoApi = dojoApi;
        }

        public async Task<Response<Refund>> CreateRefundAsync(string paymentIntentId, Guid idempotencyKey,
            CreateRefund createRefund)
        {
            
            return await ExecuteApiCallAsync(() => 
                _dojoApi.RefundPaymentIntent(idempotencyKey.ToString("N"), paymentIntentId, createRefund));
            
        }

        public async Task<Response<Refund>> GetRefundAsync(string refundId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.GetRefund(refundId));
        }

        public async Task<Response<Reversal>> ReversePaymentIntentAsync(string paymentIntentId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.ReversalPaymentIntent(paymentIntentId));
        }
    }
}