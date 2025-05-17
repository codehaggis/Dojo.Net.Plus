using System.Collections.Generic;

namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class ItemLine
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<ItemLine> Modifiers { get; set; }
        public Amount AmountTotal { get; set; }
        public string Plu { get; set; }
        
    }
}