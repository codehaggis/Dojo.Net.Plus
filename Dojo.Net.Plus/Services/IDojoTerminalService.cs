using System.Threading.Tasks;
using Dojo.Net.Plus.Api.Terminals;

namespace Dojo.Net.Plus.Services
{
    public interface IDojoTerminalService
    {
        Task<DojoResponse<TerminalSessionResponse>> CreateTerminalSessionAsync(CreateTerminalSession createTerminalSession);
        Task<DojoResponse<TerminalSessionResponse>> GetTerminalSessionAsync(string terminalSessionId);
        Task<DojoResponse<TerminalSessionResponse>> CancelTerminalSessionAsync(string terminalSessionId);
        Task<DojoResponse<TerminalSessionResponse>> AcceptSignatureTerminalSessionPaymentAsync(string terminalSession);
    }
}