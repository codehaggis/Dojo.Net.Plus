using System;
using System.Collections.Generic;
using Dojo.Net.Plus.Api.Shared;
using Dojo.Net.Plus.Api.Terminals.Enums;

namespace Dojo.Net.Plus.Api.Terminals
{
    public class TerminalSessionResponse : IResponseType
    {
        
        public string Id { get; set; }
        public string TerminalId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime ExpireAt { get; set; }
        public TerminalSessionStatus Status { get; set; }
        public List<TerminalNotificationEvent> NotificationEvents { get; set; }
        public List<StatusEvent> StatusEvents { get; set; }
        public Receipt Receipt { get; set; }
        public TerminalSessionDetails Details { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        
        
    }
}