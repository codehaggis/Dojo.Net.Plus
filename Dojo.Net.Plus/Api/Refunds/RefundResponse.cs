namespace Dojo.Net.Plus.Api.Refunds
{
    public class RefundResponse : IResponseType
    {
        public string PaymentIntentId { get; set; }
        public string RefundId { get; set; }
        public string RefundReason { get; set; }
        public string Notes { get; set; }
    }
}