using Altkom.Shop.ViewModels;
using FakeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Shop.WpfClient
{
    public class ViewModelLocator
    {
        private FrameNavigationService FrameNavigationService = new FrameNavigationService();

        public ShellViewModel ShellViewModel => new ShellViewModel(FrameNavigationService);
        public ProductsViewModel ProductsViewModel => new ProductsViewModel(new FakeProductService(), FrameNavigationService);
    }
}
