﻿using System;

namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class OrderDetails
    {
        public DateTime? AvailabilityDate { get; set; }
        public bool IsUpdate { get; set; }
        public string Id { get; set; }
        public string ExternalId { get; set; }
    }
}