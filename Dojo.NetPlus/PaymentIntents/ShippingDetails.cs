using Dojo.NetPlus.PaymentIntents;

namespace Dojo.NetPlus.PaymentIntents
{
    public class ShippingDetails
    {
        public string Name { get; set; }
        public string DeliveryNotes { get; set; }
        public Address Address { get; set; }
    }
}