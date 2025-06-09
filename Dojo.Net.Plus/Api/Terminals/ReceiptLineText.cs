using Dojo.Net.Plus.Api.Terminals.Enums;

namespace Dojo.Net.Plus.Api.Terminals
{
    public class ReceiptLineText
    {
        public string Value { get; set; }
        public ReceiptLineTextSize Size { get; set; }
        public ReceiptTextAlign Align { get; set; }
        public bool EmphasisBold { get; set; }
    }
}