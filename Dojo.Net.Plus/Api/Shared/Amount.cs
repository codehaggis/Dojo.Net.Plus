using Dojo.Net.Plus.Api.Shared.Enums;
using Dojo.Net.Plus.Api.PaymentIntents.Enums;

namespace Dojo.Net.Plus.Api.Shared
{
    public class Amount
    {
        public int Value { get; set; }
        public CurrencyCode CurrencyCode { get; set; }
    }
}