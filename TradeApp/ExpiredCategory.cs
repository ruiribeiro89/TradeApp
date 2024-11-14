
namespace TradeApp
{
    public class ExpiredCategory : ICategoryRule
    {
        public string GetCategory(ITrade trade, DateTime referenceDate)
        {
            if ((referenceDate - trade.NextPaymentDate).Days > 30)
                return "EXPIRED";
            return null;
        }
    }
}
