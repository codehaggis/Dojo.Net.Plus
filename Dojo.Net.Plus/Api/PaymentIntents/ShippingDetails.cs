﻿namespace Dojo.Net.Plus.Api.PaymentIntents
{
    public class ShippingDetails
    {
        public string Name { get; set; }
        public string DeliveryNotes { get; set; }
        public Address Address { get; set; }
    }
}