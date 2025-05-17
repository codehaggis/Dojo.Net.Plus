using System.Threading.Tasks;
using Dojo.NetPlus.Api.PaymentIntents;

namespace Dojo.NetPlus.Services
{
    public interface IPaymentIntentService
    {
        Task<Response<PaymentIntent>> CreatePaymentIntentAsync(CreatePaymentIntent createPaymentIntent);
        Task<Response<PaymentIntent>> GetPaymentIntentAsync(string paymentIntentId);
        Task<Response<PaymentIntent>> DeletePaymentIntentAsync(string paymentIntentId);
        Task<Response<CaptureResponse>> CapturePaymentIntentAsync(string paymentIntentId, CaptureRequest captureRequest);
        Task<Response<PaymentIntent>> UpdatePaymentIntentAsync(string paymentIntentId, UpdatePaymentIntent updatePaymentIntent);
    }
}