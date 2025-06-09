using Dojo.Net.Plus.Api.PaymentIntents.Enums;

namespace Dojo.Net.Plus.Api.PaymentIntents
{
    public class SupportedPaymentMethods
    {
        public CardSchemes CardSchemes { get; set; }
        public Wallets Wallets { get; set; }
    }
}