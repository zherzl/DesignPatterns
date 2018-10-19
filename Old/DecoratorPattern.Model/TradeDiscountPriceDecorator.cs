using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class TradeDiscountPriceDecorator : IPrice
    {
        private IPrice _basePrice;
        public decimal Cost { get => _basePrice.Cost * 0.95m; set => _basePrice.Cost = value; }

        public TradeDiscountPriceDecorator(IPrice price)
        {
            _basePrice = price;
        }
    }
}
