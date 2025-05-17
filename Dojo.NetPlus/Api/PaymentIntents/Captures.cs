using System;
using Dojo.NetPlus.Api.PaymentIntents.Enums;

namespace Dojo.NetPlus.Api.PaymentIntents
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