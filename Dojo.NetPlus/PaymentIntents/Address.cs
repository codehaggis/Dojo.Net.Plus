namespace Dojo.NetPlus.PaymentIntents
{
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string CountryCode { get; set; } = string.Empty;
        public string Locality { get; set; }
        public string County { get; set; }
    }
}