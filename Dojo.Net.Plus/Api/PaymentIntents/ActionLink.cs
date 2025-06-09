using Dojo.Net.Plus.Api.PaymentIntents.Enums;

namespace Dojo.Net.Plus.Api.PaymentIntents
{
    public class ActionLink
    {
        public string Url { get; set; }
        public ActionLinkAction Action { get; set; }
        public string Label { get; set; }
        public string FileName { get; set; }
    }
}