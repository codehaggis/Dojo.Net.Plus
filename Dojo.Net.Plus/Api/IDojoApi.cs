using System.Threading.Tasks;
using Dojo.Net.Plus.Api.PaymentIntents;
using Dojo.Net.Plus.Api.Refunds;
using Dojo.Net.Plus.Api.Terminals;
using Refit;

namespace Dojo.Net.Plus.Api
{
    internal interface IDojoApi
    {
        [Post("/payment-intents")]
        Task<ApiResponse<PaymentIntentResponse>> CreatePaymentIntent([Body(true)] CreatePaymentIntent paymentIntentRequest);
    
        [Get("/payment-intents/{id}")]
        Task<ApiResponse<PaymentIntentResponse>> GetPaymentIntent(string id);
        
        [Delete("/payment-intents/{id}")]
        Task<ApiResponse<PaymentIntentResponse>> CancelPaymentIntent(string id);
        
        [Post("/payment-intents/{id}/captures")]
        Task<ApiResponse<CaptureResponse>> CapturePaymentIntent(string id, [Body(true)] CaptureRequest captureRequest);
        
        [Post("/payment-intents/{id}/amount")]
        Task<ApiResponse<PaymentIntentResponse>> UpdatePaymentIntent(string id, [Body(true)] UpdatePaymentIntent updatePaymentIntent);
        
        [Post("/payment-intents/{paymentIntentId}/refresh-client-session-secret")]
        Task<ApiResponse<PaymentIntentResponse>> RefreshClientSessionSecret(string paymentIntentId);
        
        [Post("/terminal-sessions")]
        Task<ApiResponse<TerminalSessionResponse>> CreateTerminalSessionAsync([Body(true)] CreateTerminalSession terminalSession);
        
        [Get("/terminal-sessions/{id}")]
        Task<ApiResponse<TerminalSessionResponse>> GetTerminalSessionAsync(string id);
        
        [Put("/terminal-sessions/{id}/cancel")]
        Task<ApiResponse<TerminalSessionResponse>> CancelTerminalSessionAsync(string id);
        
        [Put("/terminal-sessions/{id}/signature")]
        Task<ApiResponse<TerminalSessionResponse>> AcceptSignatureTerminalSessionPaymentAsync(string id, [Body(true)] AcceptSignature signatureApproval);

        [Post("/payment-intents/{paymentIntentId}/refunds")]
        Task<ApiResponse<RefundResponse>> RefundPaymentIntent([Header("idempotencyKey")] string idempotencyKey, string paymentIntentId, [Body(true)] CreateRefund refundRequest);
        
        [Get("/payment-intents/refunds/{refundId")]
        Task<ApiResponse<RefundResponse>> GetRefund(string refundId);
        
        [Post("/payment-intents/{paymentIntentId}/reversal")]
        Task<ApiResponse<ReversalResponse>> ReversalPaymentIntent(string paymentIntentId);
        
        
    }
}