using Dojo.NetPlus.Api.Terminals.Enums;

namespace Dojo.NetPlus.Api.Terminals
{
    public class ReceiptLine
    {
        public ReceiptLineType LineType { get; set; }
        public ReceiptLineText Text { get; set; }
        public ImageLogo ImageLogo { get; set; }
        
    }
}