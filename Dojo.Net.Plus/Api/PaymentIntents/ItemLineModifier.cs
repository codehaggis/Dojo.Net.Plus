using Dojo.Net.Plus.Api.Shared;

namespace Dojo.Net.Plus.Api.PaymentIntents
{
    public class ItemLineModifier
    {
        public string Name { get; set; }
        public Amount AmountPerModifier { get; set; }
        public int Quantity { get; set; }
        public string Id { get; set; }
    }
}