﻿using System;
using Dojo.Net.Plus.Api.PaymentIntents;

namespace Dojo.Net.Plus.Api.Shared
{
    public class PaymentDetails
    {
        public string TransactionId { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public string Message { get; set; }
        public string PaymentMethodId { get; set; }
        public string AuthCode { get; set; }
        public string AvsResult { get; set; }
        public Card Card { get; set; }
        
    }
}