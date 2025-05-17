namespace Dojo.NetPlus.Api.Terminals
{
    public class TerminalSessionDetails
    {
        public UnlinkedRefund UnlinkedRefund { get; set; }
        public MatchedRefund MatchedRefund { get; set; }
        public Sale Sale { get; set; }
        public string SessionType { get; set; }
    }
}