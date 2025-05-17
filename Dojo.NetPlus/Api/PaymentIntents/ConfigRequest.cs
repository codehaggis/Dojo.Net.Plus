namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class ConfigRequest
    {
        public string Title { get; set; }
        public string RedirectUrl { get; set; }
        public string CancelUrl { get; set; }
        public ConfigDetails Details { get; set; }
        public ConfigCollectionRequired CustomerEmail { get; set; }
        public ConfigCollectionRequired BillingAddress { get; set; }
        public ConfigCollectionRequired ShippingDetails { get; set; }
        public PaymentConfig Payment { get; set; }
        
    }
}