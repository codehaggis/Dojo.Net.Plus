using System.Threading.Tasks;
using Dojo.NetPlus.Api.PaymentIntents;
using Dojo.NetPlus.Api.Refunds;
using Dojo.NetPlus.Api.Terminals;
using Refit;

namespace Dojo.NetPlus.Api
{
    internal interface IDojoApi
    {
        [Post("/payment-intents")]
        Task<ApiResponse<PaymentIntent>> CreatePaymentIntent([Body(true)] CreatePaymentIntent paymentIntentRequest);
    
        [Get("/payment-intents/{id}")]
        Task<ApiResponse<PaymentIntent>> GetPaymentIntent(string id);
        
        [Delete("/payment-intents/{id}")]
        Task<ApiResponse<PaymentIntent>> CancelPaymentIntent(string id);
        
        [Post("/payment-intents/{id}/captures")]
        Task<ApiResponse<CaptureResponse>> CapturePaymentIntent(string id, [Body] CaptureRequest captureRequest);
        
        [Post("/payment-intents/{id}/amount")]
        Task<ApiResponse<PaymentIntent>> UpdatePaymentIntent(string id, [Body] UpdatePaymentIntent updatePaymentIntent);
        
        [Post("/payment-intents/{paymentIntentId}/refresh-client-session-secret")]
        Task<ApiResponse<PaymentIntent>> RefreshClientSessionSecret(string paymentIntentId);
        
        [Post("/terminal-sessions")]
        Task<ApiResponse<TerminalSession>> CreateTerminalSessionAsync([Body] CreateTerminalSession terminalSession);
        
        [Get("/terminal-sessions/{id}")]
        Task<ApiResponse<TerminalSession>> GetTerminalSessionAsync(string id);
        
        [Put("/terminal-sessions/{id}/cancel")]
        Task<ApiResponse<TerminalSession>> CancelTerminalSessionAsync(string id);
        
        [Put("/terminal-sessions/{id}/signature")]
        Task<ApiResponse<TerminalSession>> AcceptSignatureTerminalSessionPaymentAsync(string id, [Body] AcceptSignature signatureApproval);

        [Post("/payment-intents/{paymentIntentId}/refunds")]
        Task<ApiResponse<Refund>> RefundPaymentIntent([Header("idempotencyKey")] string idempotencyKey, string paymentIntentId, [Body] CreateRefund refundRequest);
        
        [Get("/payment-intents/refunds/{refundId")]
        Task<ApiResponse<Refund>> GetRefund(string refundId);
        
        [Post("/payment-intents/{paymentIntentId}/reversal")]
        Task<ApiResponse<Refund>> ReversalPaymentIntent(string paymentIntentId);
        
        
    }
}