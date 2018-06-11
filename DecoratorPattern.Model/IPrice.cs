using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public interface IPrice
    {
        decimal Cost { get; set; }
    }
}
