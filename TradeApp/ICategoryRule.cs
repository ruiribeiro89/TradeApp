namespace TradeApp
{
    public interface ICategoryRule
    {
        string GetCategory(ITrade trade, DateTime referenceDate);
    }
}
