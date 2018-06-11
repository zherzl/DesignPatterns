using Layered.Model;
using Layered.Repository;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Layered.Web
{
    public class BootStrapper
    {
        private static Container _container;
        public Container ContainerInstance
        {
            get
            {
                if (_container == null)
                    _container = new Container();
                return _container;
            }
        }


        public static void ConfigureStructureMap()
        {
            Container container = new Container(_ =>
            {
                _.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                });
            });

            ConfigureStructureMapper(container);

            
        }

        private static void ConfigureStructureMapper(Container container)
        {
            container.Configure(c =>
            {
                c.For<IProductRepository>().Use<ProductRepository>();
            });
        }

        
    }

    
}