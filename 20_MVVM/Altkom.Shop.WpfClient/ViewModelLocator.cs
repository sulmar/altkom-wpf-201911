using Altkom.Shop.DbServices;
using Altkom.Shop.ViewModels;
using Autofac;
using FakeServices;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Shop.WpfClient
{

    // Install-Package AutoFac
    public class ViewModelLocator
    {
        private FrameNavigationService FrameNavigationService = new FrameNavigationService();

        private IContainer container;

        public ViewModelLocator()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
           // containerBuilder.RegisterType<FakeProductService>().As<IProductService>();
            containerBuilder.RegisterType<DbProductService>().As<IProductService>();
            containerBuilder.RegisterType<ShopContext>();

            containerBuilder.RegisterType<ProductsViewModel>();
            containerBuilder.RegisterType<ShellViewModel>();
            containerBuilder.RegisterType<FrameNavigationService>().As<INavigationService>().SingleInstance();

            container = containerBuilder.Build();
        }

        // public ShellViewModel ShellViewModel => new ShellViewModel(FrameNavigationService);
        // public ProductsViewModel ProductsViewModel => new ProductsViewModel(new FakeProductService(), FrameNavigationService);

        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();
        public ProductsViewModel ProductsViewModel => container.Resolve<ProductsViewModel>();


    }
}
