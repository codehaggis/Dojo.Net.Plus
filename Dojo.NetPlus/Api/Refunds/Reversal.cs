namespace Dojo.NetPlus.Api.Refunds
{
    public class Reversal : IResponseType
    {
        public string ReversalId { get; set; }
        public string Message { get; set; }
    }
}