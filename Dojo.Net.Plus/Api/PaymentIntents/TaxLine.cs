using Dojo.Net.Plus.Api.Shared;

namespace Dojo.Net.Plus.Api.PaymentIntents
{
    public class TaxLine
    {
        public string Id { get; set; }
        public string Caption { get; set; }
        public string SubCaption { get; set; }
        public Amount AmountTotal { get; set; }
        public string AffectedPlu { get; set; }
    }
}