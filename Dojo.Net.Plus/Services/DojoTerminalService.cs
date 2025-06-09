using System;
using System.Text.Json;
using System.Threading.Tasks;
using Dojo.Net.Plus.Api;
using Dojo.Net.Plus.Api.Terminals;

namespace Dojo.Net.Plus.Services
{
    internal sealed class DojoTerminalService : BaseService, IDojoTerminalService
    {
        
        private readonly IDojoApi _dojoApi;

        public DojoTerminalService(IDojoApi dojoApi)
        {
            if (string.IsNullOrEmpty(OptionsStore.Options.SoftwareHouseId) ||
                string.IsNullOrEmpty(OptionsStore.Options.ResellerId))
            {
                throw new InvalidOperationException("SoftwareHouseId and ResellerId must be set in options to use Terminal endpoints.");
            }
            _dojoApi = dojoApi;
        }
        
        
        public async Task<DojoResponse<TerminalSessionResponse>> CreateTerminalSessionAsync(CreateTerminalSession createTerminalSession)
        {
            
            return await ExecuteApiCallAsync(() => _dojoApi.CreateTerminalSessionAsync(createTerminalSession));
            
        }
        
        public async Task<DojoResponse<TerminalSessionResponse>> GetTerminalSessionAsync(string terminalSessionId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.GetTerminalSessionAsync(terminalSessionId));
        }

        public async Task<DojoResponse<TerminalSessionResponse>> CancelTerminalSessionAsync(string terminalSessionId)
        {
            return await ExecuteApiCallAsync(() => _dojoApi.CancelTerminalSessionAsync(terminalSessionId));
        }

        public async Task<DojoResponse<TerminalSessionResponse>> AcceptSignatureTerminalSessionPaymentAsync(string terminalSessionId)
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