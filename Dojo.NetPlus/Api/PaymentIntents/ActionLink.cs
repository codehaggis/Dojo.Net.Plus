using Dojo.NetPlus.Api.PaymentIntents.Enums;

namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class ActionLink
    {
        public string Url { get; set; }
        public ActionLinkAction Action { get; set; }
        public string Label { get; set; }
        public string FileName { get; set; }
    }
}