using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class CurrencyPriceDecorator : IPrice
    {
        private IPrice _basePrice;
        private decimal _exchangeRate;
        public decimal Cost { get => _basePrice.Cost * _exchangeRate; set => _basePrice.Cost = value; }

        public CurrencyPriceDecorator(IPrice price, decimal exchangeRate)
        {
            _basePrice = price;
            _exchangeRate = exchangeRate;
        }
    }
}
