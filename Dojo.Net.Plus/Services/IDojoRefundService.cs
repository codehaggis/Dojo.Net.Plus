using System;
using System.Threading.Tasks;
using Dojo.Net.Plus.Api.Refunds;

namespace Dojo.Net.Plus.Services
{
    public interface IDojoRefundService
    {
        Task<DojoResponse<RefundResponse>> CreateRefundAsync(string paymentIntentId, Guid idempotencyKey, CreateRefund createRefund);
        Task<DojoResponse<RefundResponse>> GetRefundAsync(string refundId);
        Task<DojoResponse<ReversalResponse>> ReversePaymentIntentAsync(string paymentIntentId);
    }
}