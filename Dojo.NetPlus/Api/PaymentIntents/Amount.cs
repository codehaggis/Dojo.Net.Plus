using Dojo.NetPlus.Api.PaymentIntents.Enums;

namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class Amount
    {
        public int Value { get; set; }
        public CurrencyCode CurrencyCode { get; set; }
    }
}