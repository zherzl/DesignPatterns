using Layered.Model;
using Layered.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> FindAll()
        {
            IList<Product> productsListNew = new List<Product>();

            var productsList = new ShopContext().Products.ToList();

            foreach (var item in productsList)
            {
                Product p = new Product { ProductId = item.ProductId, ProductName = item.ProductName };
                p.Price = new Price(item.RRP, item.SellingPrice);

                productsListNew.Add(p);
            }

            return productsListNew;
        }
    }
}
