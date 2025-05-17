using System;
using Dojo.NetPlus.Api.Terminals.Enums;

namespace Dojo.NetPlus.Api.Terminals
{
    public class StatusEvent
    {
        public TerminalStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DebugMessage { get; set; }
    }
}