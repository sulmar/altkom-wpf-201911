using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Altkom.Shop.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;

        public ICommand ShowProductsCommand { get; set; }
        public ICommand ShowCustomersCommand { get; set; }

        public ShellViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            ShowCustomersCommand = new RelayCommand(ShowCustomer);
            ShowProductsCommand = new RelayCommand(ShowProducts);
        }

        private void ShowProducts()
        {
            navigationService.Navigate("Products");
        }

        private void ShowCustomer()
        {
            navigationService.Navigate("Customers");
        }

 
    }
}
