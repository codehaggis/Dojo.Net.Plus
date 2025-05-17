using System;
using Dojo.NetPlus.Api.Terminals.Enums;

namespace Dojo.NetPlus.Api.Terminals
{
    public class TerminalNotificationEvent
    {
        public TerminalNotificationType NotificationType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}