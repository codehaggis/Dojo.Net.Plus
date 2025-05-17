using System;
using Dojo.NetPlus.Api.Terminals.Enums;

namespace Dojo.NetPlus.Api.Terminals
{
    public class Terminal
    {
        public string Id { get; set; }
        public TerminalProperties Properties { get; set; }
        public TerminalStatus Status { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}