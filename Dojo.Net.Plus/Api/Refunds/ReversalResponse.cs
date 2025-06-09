namespace Dojo.Net.Plus.Api.Refunds
{
    public class ReversalResponse : IResponseType
    {
        public string ReversalId { get; set; }
        public string Message { get; set; }
    }
}