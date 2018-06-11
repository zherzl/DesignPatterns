using Layered.Service;
using Layered.Service.Implementations;
using Layered.Service.Messaging;
using Layered.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Presentation
{
    public class ProductListPresenter
    {
        private IProductListView _productListView;
        private IProductService _productService;
        private StructureMapConfig smap = StructureMapConfig.GetInstance;

        public ProductListPresenter(IProductListView ProductListView)
        {
            _productService = smap._Container.GetInstance<IProductService>();
            _productListView = ProductListView;
        }

        public void Display()
        {
            ProductListRequest productListRequest = new ProductListRequest();
            productListRequest.CustomerType = _productListView.CustomerType;
            ProductListResponse productResponse =
            _productService.GetAllProductsFor(productListRequest);

            if (productResponse.Success)
            {
                _productListView.Display(productResponse.Products);
            }
            else
            {
                _productListView.ErrorMessage = productResponse.Message;
            }
        }
    }
}
