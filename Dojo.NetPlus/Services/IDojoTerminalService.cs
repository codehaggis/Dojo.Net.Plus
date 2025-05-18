using System.Threading.Tasks;
using Dojo.NetPlus.Api.Terminals;

namespace Dojo.NetPlus.Services
{
    public interface IDojoTerminalService
    {
        Task<Response<TerminalSession>> CreateTerminalSessionAsync(CreateTerminalSession createTerminalSession);
        Task<Response<TerminalSession>> GetTerminalSessionAsync(string terminalSessionId);
        Task<Response<TerminalSession>> CancelTerminalSessionAsync(string terminalSessionId);
        Task<Response<TerminalSession>> AcceptSignatureTerminalSessionPaymentAsync(string terminalSession);
    }
}