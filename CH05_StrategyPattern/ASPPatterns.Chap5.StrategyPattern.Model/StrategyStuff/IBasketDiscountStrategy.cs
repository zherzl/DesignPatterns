using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.StrategyPattern.Model.StrategyStuff
{
    public interface IBasketDiscountStrategy
    {
        decimal GetTotalCostAfterApplyingDiscountTo(Basket basket);
    }

}
