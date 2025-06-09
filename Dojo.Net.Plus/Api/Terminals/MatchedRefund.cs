using Dojo.Net.Plus.Api.Shared;

namespace Dojo.Net.Plus.Api.Terminals
{
    public class MatchedRefund
    {
        public string PaymentIntentId { get; set; }
        public Amount Amount { get; set; }
        
    }
}