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
        private readonly INavigationService navigationService;
        private IEnumerable<Product> products;

        public ICommand SearchCommand { get; set; }

        public ProductSearchCriteria Criteria { get; set; }

        //public ProductsViewModel()
        //    : this(new FakeProductService(), new Fr)
        //{

        //}


        public ProductsViewModel(
            IProductService productService, 
            INavigationService navigationService)
        {
            this.productService = productService;
            this.navigationService = navigationService;

            Criteria = new ProductSearchCriteria();

            SearchCommand = new RelayCommand(Search);

        }
     

        private void Search()
        {
            Products = productService.Get(Criteria);

            foreach (var product in Products)
            {
                product.PropertyChanged += Product_PropertyChanged;
            }

        }

        private void Product_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
          if(e.PropertyName == nameof(Product.UnitPrice))
            {
                
            }
        }
    }
}
