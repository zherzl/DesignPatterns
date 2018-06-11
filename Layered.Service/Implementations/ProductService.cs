using Layered.Model;
using Layered.Model.Models;
using Layered.Model.Strategy;
using Layered.Service.Messaging;
using Layered.Service.ViewModelExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Service.Implementations
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductListResponse GetAllProductsFor(ProductListRequest request)
        {
            ProductListResponse productListResponse = new ProductListResponse();

            try
            {
                IDiscountStrategy discountStrategy = DiscountFactory.GetDiscountStrategyFor(request.CustomerType);
                IList<Product> products = _productRepository.FindAll();
                products.Apply(discountStrategy);

                productListResponse.Products = products.ConvertToProductListViewModel();
                productListResponse.Success = true;
            }
            catch (Exception ex)
            {
                productListResponse.Success = false;
                productListResponse.Message = ex.Message;
            }

            return productListResponse;
        }


    }
}
