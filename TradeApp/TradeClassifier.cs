using System;
using System.Collections.Generic;

namespace TradeApp
{
    public class TradeClassifier
    {
        private readonly List<ICategoryRule> _rules;

        public TradeClassifier()
        {
            //sequencia as regras
            _rules = new List<ICategoryRule>
            {
                new PepCategory(),
                new ExpiredCategory(),
                new HighRiskCategory(),
                new MediumRiskCategory()
            };
        }

        public string ClassifyTrade(ITrade trade, DateTime referenceDate)
        {
            //percorre as regras ate atender alguma caso contrario retorna valor fora do laco
            foreach (var rule in _rules)
            {
                var category = rule.GetCategory(trade, referenceDate);
                if (category != null)
                    return category;
            }
            return "UNCLASSIFIED";
        }
    }
}
