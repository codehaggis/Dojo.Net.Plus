namespace Dojo.Net.Plus.Api.Refunds
{
    public class CreateRefund
    {
        public int Amount { get; set; }
        public string PreviousTransactionId { get; set; }
        public string RefundReason { get; set; }
        public string Notes { get; set; }
    }
}