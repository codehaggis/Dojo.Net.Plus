using System.Threading.Tasks;
using Dojo.NetPlus.Api.PaymentIntents;
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
        //
        // [Post("/terminal-sessions")]
        // Task<ApiResponse<TerminalSessionResponse>> CreateTerminalSessionAsync([Body] TerminalSession terminalSession);
        //
        // [Get("/terminal-sessions/{id}")]
        // Task<ApiResponse<TerminalSessionResponse>> GetTerminalSessionAsync(string id);
        //
        // [Put("/terminal-sessions/{id}/cancel")]
        // Task<ApiResponse<TerminalSessionResponse>> CancelTerminalSessionAsync(string id);
        //
        // [Put("/terminal-sessions/{id}/signature")]
        // Task<ApiResponse<TerminalSessionResponse>> AcceptSignatureTerminalSessionPaymentAsync(string id, [Body] TerminalSessionSignatureApproval signatureApproval);

    }
}