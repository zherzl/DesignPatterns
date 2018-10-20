using CH05_ASPPatterns.Chap5.DecoratorPattern.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_ASPPatterns.Chap5.DecoratorPattern.Model.Services
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> products = _productRepository.FindAll();
            products.ApplyTradeDiscount();
            products.ApplyCurrencyMultiplier();
            return products;
        }

    }
}
