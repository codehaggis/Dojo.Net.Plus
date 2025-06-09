using System;
using Dojo.Net.Plus.Api.Terminals.Enums;

namespace Dojo.Net.Plus.Api.Terminals
{
    public class TerminalSessionDetails
    {
        
        public UnlinkedRefund UnlinkedRefund { get; set; }
        public MatchedRefund MatchedRefund { get; set; }
        public Sale Sale { get; set; }
        public SessionType SessionType { get; set; }
    }
}