using System;
using System.Threading.Tasks;
using Dojo.NetPlus.Api.Refunds;

namespace Dojo.NetPlus.Services
{
    public interface IDojoRefundService
    {
        Task<Response<Refund>> CreateRefundAsync(string paymentIntentId, Guid idempotencyKey, CreateRefund createRefund);
        Task<Response<Refund>> GetRefundAsync(string refundId);
        Task<Response<Refund>> ReversePaymentIntentAsync(string paymentIntentId);
    }
}