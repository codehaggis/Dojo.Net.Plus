using System;
using System.Collections.Generic;
using Dojo.NetPlus.Api.PaymentIntents.Enums;


namespace Dojo.NetPlus.Api.PaymentIntents
{
    public class PaymentIntent : IResponseType
    {
        // todo TerminalSessions
        
        public string Id { get; set; }
        public string ClientSessionSecret { get; set; }
        public DateTime? ClientSessionSecretExpirationDate { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        public Status Status { get; set; }
        public Amount RequestedAmount { get; set; }
        public Amount TotalAmount { get; set; }
        public int RefundedAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public MerchantConfig MerchantConfig { get; set; }
        public string PaymentLink { get; set; }
        public List<Captures> Captures { get; set; }
        public CaptureMode CaptureMode { get; set; } 
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