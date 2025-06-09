using System;
using Dojo.Net.Plus.Api.Terminals.Enums;

namespace Dojo.Net.Plus.Api.Terminals
{
    public class StatusEvent
    {
        public TerminalSessionStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DebugMessage { get; set; }
    }
}