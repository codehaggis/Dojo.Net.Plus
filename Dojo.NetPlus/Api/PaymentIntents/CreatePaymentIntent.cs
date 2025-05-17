﻿using System;
using System.Collections.Generic;
using Dojo.NetPlus.Api.PaymentIntents.Enums;
using Dojo.NetPlus.Api.PaymentIntents.Enums;
using Dojo.NetPlus.Api.Shared;

namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class CreatePaymentIntent
    {
        public CaptureMode CaptureMode { get; set; } = CaptureMode.Auto;
        public Amount Amount  { get; set; }
        public Amount TipsAmount { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime? ExpireAt { get; set; }
        public TimeSpan? AutoExpireIn {get; set;}
        public ExpireAction? AutoExpireAction { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public CustomerDetails Customer { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public bool CardHolderNotPresent { get; set; }
        public ConfigRequest Config { get; set; }
        public RequestSecurity RequestSecurity { get; set; }
        public List<ItemLine> ItemLines { get; set; }
        public List<TaxLine> TaxLines { get; set; }
        public ActionLink ActionLink { get; set; }
        public string SetupIntentId { get; set; }
        public OrderDetails OrderDetails { get; set; }
        public Amount CashbackAmount { get; set; }
        public Amount ServiceChargeAmount { get; set; }
        public bool GenerateRemoteToken { get; set; }
        
    }
}