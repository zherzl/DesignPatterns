using System.Collections.Generic;

namespace Model
{
    public interface IProductRepository
    {
        IEnumerable<Product> FindAll();
    }
}