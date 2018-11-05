using System.Collections.Generic;

namespace Model
{
    public class ProductService
    {
        private IProductRepository _productRepository;
        private IProductDiscountStrategy _discountStrategy;
        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
            //this._discountStrategy = new ChristmasProductDiscount();
        }
        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> products = _productRepository.FindAll();
            foreach (Product p in products)
                p.AdjustPriceWith(_discountStrategy);
            return products;
        }


        public IEnumerable<Product> GetProductsAndApplyDiscount(IProductDiscountStrategy discount)
        {
            IEnumerable<Product> products = _productRepository.FindAll();

            foreach (Product p in products)
                p.AdjustPriceWith(discount);

            return products;
        }
    }
}