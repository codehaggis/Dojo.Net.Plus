using System;
using System.Collections.Generic;
using Dojo.NetPlus.Api.Shared;
using Dojo.NetPlus.Api.Terminals.Enums;

namespace Dojo.NetPlus.Api.Terminals
{
    public class TerminalSession : IResponseType
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