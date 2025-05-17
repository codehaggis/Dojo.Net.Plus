using Dojo.NetPlus.Api.PaymentIntents.Enums;
using Dojo.NetPlus.Api.Shared.Enums;

namespace Dojo.NetPlus.Api.Shared
{
    public class Amount
    {
        public int Value { get; set; }
        public CurrencyCode CurrencyCode { get; set; }
    }
}