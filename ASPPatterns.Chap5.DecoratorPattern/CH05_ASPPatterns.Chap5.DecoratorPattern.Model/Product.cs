using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_ASPPatterns.Chap5.DecoratorPattern.Model
{
    public class Product
    {
        public IPrice Price { get; set; }
    }
}
