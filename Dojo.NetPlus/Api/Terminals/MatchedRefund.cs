using Dojo.NetPlus.Api.Shared;

namespace Dojo.NetPlus.Api.Terminals
{
    public class MatchedRefund
    {
        public string PaymentIntentId { get; set; }
        public Amount Amount { get; set; }
        
    }
}