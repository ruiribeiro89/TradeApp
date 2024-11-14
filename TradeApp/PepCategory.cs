namespace TradeApp
{
    public class PepCategory : ICategoryRule
    {
        public string GetCategory(ITrade trade, DateTime referenceDate)
        {
            if (trade.IsPoliticallyExposed)
                return "POLITICALLYEXPOSED";
            return null;
        }
    }
}
