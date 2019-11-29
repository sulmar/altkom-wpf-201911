using Altkom.Shop.Models;
using FakeServices;
using IServices;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Altkom.Shop.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public IEnumerable<Product> Products
        {
            get => products; set
            {
                products = value;

                OnPropertyChanged();
            }
        }

        private readonly IProductService productService;
        private IEnumerable<Product> products;

        public ICommand SearchCommand { get; set; }

        public ProductSearchCriteria Criteria { get; set; }

        public ProductsViewModel()
            : this(new FakeProductService())
        {

        }

        public ProductsViewModel(IProductService productService)
        {
            this.productService = productService;

            Criteria = new ProductSearchCriteria();

            SearchCommand = new RelayCommand(Search);

        }

        private void Search()
        {
            Products = productService.Get(Criteria);
        }

    }
}
