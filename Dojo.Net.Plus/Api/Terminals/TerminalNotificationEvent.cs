﻿using System;
using Dojo.Net.Plus.Api.Terminals.Enums;

namespace Dojo.Net.Plus.Api.Terminals
{
    public class TerminalNotificationEvent
    {
        public TerminalNotificationType NotificationType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}