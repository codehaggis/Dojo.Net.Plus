using System;
using System.Text.Json;
using System.Threading.Tasks;
using Dojo.NetPlus.Api;
using Dojo.NetPlus.Api.Terminals;

namespace Dojo.NetPlus.Services
{
    internal sealed class DojoTerminalService : BaseService, IDojoTerminalService
    {
        
        private readonly IDojoApi _dojoApi;

        public DojoTerminalService(IDojoApi dojoApi)
        {
            _dojoApi = dojoApi;
        }
        
        
        public async Task<Response<TerminalSession>> CreateTerminalSessionAsync(CreateTerminalSession createTerminalSession)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.CreateTerminalSessionAsync(createTerminalSession));
            
        }
        
        public async Task<Response<TerminalSession>> GetTerminalSessionAsync(string terminalSessionId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.GetTerminalSessionAsync(terminalSessionId));
        }

        public async Task<Response<TerminalSession>> CancelTerminalSessionAsync(string terminalSessionId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.CancelTerminalSessionAsync(terminalSessionId));
        }

        public async Task<Response<TerminalSession>> AcceptSignatureTerminalSessionPaymentAsync(string terminalSessionId)
        {
            var signatureApproval = new AcceptSignature
            {
                Accepted = true
            };
            
            return await ExecuteApiCallAsync(() => 
                _dojoApi.AcceptSignatureTerminalSessionPaymentAsync(terminalSessionId, signatureApproval));
        }
    }
}