namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class CaptureResponse : IResponseType
    {
        public string Message { get; set; }
        public string CaptureId { get; set; }
    }
}