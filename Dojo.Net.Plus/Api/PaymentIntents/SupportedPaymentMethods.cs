using System.Collections.Generic;
using Dojo.Net.Plus.Api.PaymentIntents.Enums;

namespace Dojo.Net.Plus.Api.PaymentIntents
{
    public class SupportedPaymentMethods
    {
        public List<CardSchemes> CardSchemes { get; set; }
        public List<Wallets> Wallets { get; set; }
    }
}