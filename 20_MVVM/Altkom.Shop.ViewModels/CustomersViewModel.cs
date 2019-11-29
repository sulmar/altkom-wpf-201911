using Altkom.Shop.Models;
using FakeServices;
using IServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace Altkom.Shop.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        private readonly IProductService productService;

        public ProductsViewModel()
            : this(new FakeProductService())
        {

        }

        public ProductsViewModel(IProductService productService)
        {
            this.productService = productService;

            Load();
        }

        private void Load()
        {
            Products = productService.Get();
        }
    }

    public class CustomersViewModel : BaseViewModel
    {
        public IEnumerable<Customer> Customers { get; private set; }

        private Customer selectedCustomer;
        public Customer SelectedCustomer 
        { 
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                SendCommand.OnCanExecuteChanged();

                SelectedCustomer.PropertyChanged += SelectedCustomer_PropertyChanged;
            }
        }

        private readonly ICustomerService customerService;

        public RelayCommand SendCommand { get; private set; }

        // ctor
        public CustomersViewModel()
            : this(new FakeCustomerService())
        {

        }

        public CustomersViewModel(ICustomerService customerService)
        {
            this.customerService = customerService;

            SendCommand = new RelayCommand(Send, CanSend);

            Load();
        }

        private void SelectedCustomer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            SendCommand.OnCanExecuteChanged();
        }

        private void Load()
        {
            Customers = customerService.Get();
        }

        public void Send()
        {
            Trace.WriteLine($"Sending email to {SelectedCustomer.FullName}...");
        }

        public bool CanSend()
        {
            return SelectedCustomer != null
                && !string.IsNullOrEmpty(SelectedCustomer.FirstName);
        }
    }
}
