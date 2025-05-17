using System.Collections.Generic;
using Dojo.NetPlus.Api.Shared;

namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class UpdatePaymentIntent
    {
        public Amount Amount { get; set; }
        public List<ItemLine> ItemLines { get; set; }
        public List<TaxLine> TaxLines { get; set; }
    }
}