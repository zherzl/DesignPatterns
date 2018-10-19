using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.CH2.Service
{
    interface IProductRepository
    {
        IList<Product> GetAllProductsIn(int categoryId);
    }
}
