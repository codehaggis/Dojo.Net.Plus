namespace Dojo.Net.Plus.Api.Terminals.Enums
{
    public enum TerminalSessionStatus
    {
        InitiateRequested = 0,
        Initiated = 1,
        Authorized = 2,
        Captured = 3,
        CancelRequested = 4,
        Canceled = 5,
        SignatureVerificationAccepted = 6,
        SignatureVerificationRejected = 7,
        SignatureVerificationRequired = 8,
        Expired = 9,
        Declined = 10
    }
}