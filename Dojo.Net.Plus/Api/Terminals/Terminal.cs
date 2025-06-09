using System;
using Dojo.Net.Plus.Api.Terminals.Enums;

namespace Dojo.Net.Plus.Api.Terminals
{
    public class Terminal : IResponseType
    {
        public string Id { get; set; }
        public TerminalProperties Properties { get; set; }
        public TerminalStatus Status { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}