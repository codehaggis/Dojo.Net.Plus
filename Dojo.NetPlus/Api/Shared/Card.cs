using Dojo.NetPlus.Api.Shared.Enums;

namespace Dojo.NetPlus.Api.Shared
{
    public class Card
    {
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CardName { get; set; }
        public string CardType { get; set; }
        public CardFundingType CardFundingType { get; set; }
        public string Last4Pan { get; set; }
        public EntryMode EntryMode { get; set; }
        public VerificationMethod VerificationMethod { get; set; }
        
    }
}