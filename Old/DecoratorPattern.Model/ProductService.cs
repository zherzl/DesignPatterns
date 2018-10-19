using System.Collections;
using System.Collections.Generic;

namespace DecoratorPattern.Model
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