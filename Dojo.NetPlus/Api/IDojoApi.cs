using System.Threading.Tasks;
using Refit;

namespace Dojo.NetPlus.Api
{
    public interface IDojoApi
    {
        [Post("/payment-intents")]
        Task<ApiResponse<DojoPaymentIntentResponse>> CreatePaymentIntent([Body(true)] DojoPaymentIntentRequest paymentIntentRequest);
    
        [Get("/payment-intents/{id}")]
        Task<ApiResponse<DojoPaymentIntentResponse>> GetPaymentIntent(string id);
    
        [Delete("/payment-intents/{id}")]
        Task<ApiResponse<DojoPaymentIntentResponse>> CancelPaymentIntent(string id);
    
        [Post("/payment-intents/{id}/captures")]
        Task<ApiResponse<CaptureResponse>> CapturePaymentIntent(string id, [Body] CaptureRequest captureRequest);
    
        [Post("/terminal-sessions")]
        Task<ApiResponse<TerminalSessionResponse>> CreateTerminalSessionAsync([Body] TerminalSession terminalSession);
    
        [Get("/terminal-sessions/{id}")]
        Task<ApiResponse<TerminalSessionResponse>> GetTerminalSessionAsync(string id);
    
        [Put("/terminal-sessions/{id}/cancel")]
        Task<ApiResponse<TerminalSessionResponse>> CancelTerminalSessionAsync(string id);
    
        [Put("/terminal-sessions/{id}/signature")]
        Task<ApiResponse<TerminalSessionResponse>> AcceptSignatureTerminalSessionPaymentAsync(string id, [Body] TerminalSessionSignatureApproval signatureApproval);

    }
}