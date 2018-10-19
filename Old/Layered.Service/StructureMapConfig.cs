using Layered.Service;
using Layered.Service.Implementations;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Layered.Web.App_Start
{
    public class StructureMapConfig
    {
        private static StructureMapConfig instance = null;
        private Container _container = new Container();
        public static StructureMapConfig GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StructureMapConfig();
                }

                return instance;
            }
        }

        private void ConfigureContainer()
        {
            _Container.Configure(_ => _.Scan(
                x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                }));

            _Container.Configure(x =>
            {
                x.For<Model.IProductRepository>().Use<Repository.ProductRepository>();

                x.For<IProductService>().Use<ProductService>();
            });
        }

        public Container _Container { get { return _container; } }

        private StructureMapConfig()
        {
            ConfigureContainer();
        }




    }
}