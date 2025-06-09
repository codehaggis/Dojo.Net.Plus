using Dojo.Net.Plus.Api.Terminals.Enums;

namespace Dojo.Net.Plus.Api.Terminals
{
    public class ReceiptLine
    {
        public ReceiptLineType LineType { get; set; }
        public ReceiptLineText Text { get; set; }
        public ImageLogo ImageLogo { get; set; }
        
    }
}