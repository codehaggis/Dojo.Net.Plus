using System;
using Dojo.NetPlus.Api.Terminals.Enums;

namespace Dojo.NetPlus.Api.Terminals
{
    public class StatusEvent
    {
        public TerminalSessionStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DebugMessage { get; set; }
    }
}