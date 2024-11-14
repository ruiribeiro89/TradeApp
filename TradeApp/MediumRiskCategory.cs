namespace TradeApp
{
    public class MediumRiskCategory : ICategoryRule
    {
        public string GetCategory(ITrade trade, DateTime referenceDate)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Public")
                return "MEDIUMRISK";
            return null;
        }
    }
}
