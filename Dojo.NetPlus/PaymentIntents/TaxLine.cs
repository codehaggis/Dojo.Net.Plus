namespace Dojo.NetPlus.PaymentIntents
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