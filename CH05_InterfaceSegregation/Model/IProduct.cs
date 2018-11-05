using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IProduct
    {
        decimal Price { get; set; }
        decimal WeightInKg { get; set; }
        int Stock { get; set; }
        //int Certification { get; set; }
        //int RunningTime { get; set; }

    }
}
