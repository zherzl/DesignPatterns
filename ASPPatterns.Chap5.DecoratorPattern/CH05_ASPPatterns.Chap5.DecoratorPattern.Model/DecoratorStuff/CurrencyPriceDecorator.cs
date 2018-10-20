using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_ASPPatterns.Chap5.DecoratorPattern.Model
{
    public class CurrencyPriceDecorator : IPrice
    {
        private IPrice _basePrice;
        private decimal _exchangeRate;
        public CurrencyPriceDecorator(IPrice price, decimal exchangeRate)
        {
            this._basePrice = price;
            this._exchangeRate = exchangeRate;
        }
        public decimal Cost
        {
            get { return _basePrice.Cost * _exchangeRate; }
            set { _basePrice.Cost = value; }
        }
    }
}
