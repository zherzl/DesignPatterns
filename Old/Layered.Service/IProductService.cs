using Layered.Service.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Service
{
    public interface IProductService
    {
        ProductListResponse GetAllProductsFor(ProductListRequest request);
    }
}
