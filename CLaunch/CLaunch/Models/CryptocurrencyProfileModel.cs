namespace CLaunch.Models
{
    public class CryptocurrencyProfileModel
    {
        public DateTime MarketOpening { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public int Amount { get; set; }
        public List<ValueByDayModel> ValueByDay { get; set; }
    }

    public class ValueByDayModel
    {
        public int MedianValue { get; set; }    
        public DateTime DateTime { get; set; }
    }
}
