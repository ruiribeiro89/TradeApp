namespace TradeApp
{
    public class HighRiskCategory : ICategoryRule
    {
        public string GetCategory(ITrade trade, DateTime referenceDate)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Private")
                return "HIGHRISK";
            return null;
        }
    }
}
