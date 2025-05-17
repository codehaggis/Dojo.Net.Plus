using Dojo.NetPlus.Api.PaymentIntents.Enums;

namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class SupportedPaymentMethods
    {
        public CardSchemes CardSchemes { get; set; }
        public Wallets Wallets { get; set; }
    }
}