using System.Threading.Tasks;
using Dojo.Net.Plus.Api.PaymentIntents;

namespace Dojo.Net.Plus.Services
{
    public interface IDojoPaymentIntentService
    {
        Task<DojoResponse<PaymentIntentResponse>> CreatePaymentIntentAsync(CreatePaymentIntent createPaymentIntent);
        Task<DojoResponse<PaymentIntentResponse>> GetPaymentIntentAsync(string paymentIntentId);
        Task<DojoResponse<PaymentIntentResponse>> DeletePaymentIntentAsync(string paymentIntentId);
        Task<DojoResponse<CaptureResponse>> CapturePaymentIntentAsync(string paymentIntentId, CaptureRequest captureRequest);
        Task<DojoResponse<CaptureResponse>> CapturePaymentIntentAsync(string paymentIntentId, int amount);
        Task<DojoResponse<PaymentIntentResponse>> UpdatePaymentIntentAsync(string paymentIntentId, UpdatePaymentIntent updatePaymentIntent);
        Task<DojoResponse<PaymentIntentResponse>> RefreshClientSessionSecretAsync(string paymentIntentId);
    }
}