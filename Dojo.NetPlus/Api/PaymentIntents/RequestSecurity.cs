﻿namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class RequestSecurity
    {
        public string UserAgent { get; set; }
        public string IpAddress { get; set; }
        public string Device { get; set; }
    }
}