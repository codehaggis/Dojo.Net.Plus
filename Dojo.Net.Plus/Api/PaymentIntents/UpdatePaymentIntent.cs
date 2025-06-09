using System.Collections.Generic;
using Dojo.Net.Plus.Api.Shared;

namespace Dojo.Net.Plus.Api.PaymentIntents
{
    public class UpdatePaymentIntent
    {
        public Amount Amount { get; set; }
        public List<ItemLine> ItemLines { get; set; }
        public List<TaxLine> TaxLines { get; set; }
    }
}