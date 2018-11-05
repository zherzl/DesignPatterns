using ASPPatterns.Chap5.StrategyPattern.Model.StrategyStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.StrategyPattern.Model
{
    public class Basket
    {
        IBasketDiscountStrategy _basketDiscountStrategy;

        public Basket(DiscountTypeEnum discountType)
        {
            _basketDiscountStrategy = BasketDiscountFactory.GetDiscount(discountType);
        }
        public decimal TotalCost { get; set; }

        public decimal GetTotalCostAfterDiscount()
        {
            return _basketDiscountStrategy.GetTotalCostAfterApplyingDiscountTo(this);
        }
    }
}
