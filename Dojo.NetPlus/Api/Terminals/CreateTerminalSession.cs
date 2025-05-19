using Dojo.NetPlus.Api.Shared;
using Dojo.NetPlus.Api.Shared.Enums;
using Dojo.NetPlus.Api.Terminals.Enums;

namespace Dojo.NetPlus.Api.Terminals
{
    public class CreateTerminalSession
    {
        public string TerminalId { get; set; }
        public TerminalSessionDetails Details { get; set; }


        /// <summary>
        /// Sale terminal session, used for initialising a payment.
        /// </summary>
        public CreateTerminalSession(string terminalId, string paymentIntentId)
        {
            
            // Sale
            TerminalId = terminalId;
            Details = new TerminalSessionDetails
            {
                Sale = new Sale
                {
                    PaymentIntentId = paymentIntentId,
                },
                SessionType = SessionType.Sale
            };
        }

        /// <summary>
        /// Matched refund terminal session, used for refunding a payment with a corresponding payment intent.
        /// </summary>
        public CreateTerminalSession(string terminalId, string paymentIntentId, int matchedRefundAmount,
            CurrencyCode currency)
        {
            // matched refund
            TerminalId = terminalId;
            Details = new TerminalSessionDetails
            {
                MatchedRefund = new MatchedRefund
                {
                    PaymentIntentId = paymentIntentId,
                    Amount = new Amount
                    {
                        Value = matchedRefundAmount,
                        CurrencyCode = currency
                    }
                },
                SessionType = SessionType.MatchedRefund
            };
            
        }
        
        /// <summary>
        /// Unlinked refund terminal session, used for refunding a payment without a corresponding payment intent.
        /// </summary>
        public CreateTerminalSession(string terminalId, int unlinkedRefundAmount, CurrencyCode currency)
        {
            // Unlinked refund
            TerminalId = terminalId;
            Details = new TerminalSessionDetails
            {
                UnlinkedRefund = new UnlinkedRefund
                {
                    Amount = new Amount
                    {
                        Value = unlinkedRefundAmount,
                        CurrencyCode = currency
                    }
                },
                SessionType = SessionType.UnlinkedRefund
            };
            
        }
        
    }
}