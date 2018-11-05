using ASPPatterns.Chap5.StrategyPattern.Model.StrategyStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.StrategyPattern.Model
{
    public static class BasketDiscountFactory
    {
        public static IBasketDiscountStrategy GetDiscount(DiscountTypeEnum discountType)
        {
            switch (discountType)
            {
                case DiscountTypeEnum.NoDiscount:
                    return new NoBasketDiscount();
                case DiscountTypeEnum.MoneyOff:
                    return new BasketDiscountMoneyOff();
                case DiscountTypeEnum.PercentageOff:
                    return new BasketDiscountPercentageOff();
                default:
                    return new NoBasketDiscount();
            }
        }
    }
}
