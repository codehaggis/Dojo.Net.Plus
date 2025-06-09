using System;
using Dojo.Net.Plus.Api.PaymentIntents.Enums;

namespace Dojo.Net.Plus.Api.PaymentIntents
{
    public class Captures
    {
        public string Id { get; set; }
        public int Amount { get; set; }
        public int TipsAmount { get; set; }
        public ChargeStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}