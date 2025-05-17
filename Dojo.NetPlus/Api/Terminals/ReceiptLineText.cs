using Dojo.NetPlus.Api.Terminals.Enums;

namespace Dojo.NetPlus.Api.Terminals
{
    public class ReceiptLineText
    {
        public string Value { get; set; }
        public ReceiptLineTextSize Size { get; set; }
        public ReceiptTextAlign Align { get; set; }
        public bool EmphasisBold { get; set; }
    }
}