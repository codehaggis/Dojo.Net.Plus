namespace Dojo.NetPlus.Api.Refunds
{
    public class Refund : IResponseType
    {
        public string PaymentIntentId { get; set; }
        public string RefundId { get; set; }
        public string RefundReason { get; set; }
        public string Notes { get; set; }
    }
}