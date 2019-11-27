using Altkom.Shop.Models;
using FakeServices;
using IServices;
using System;
using System.Collections.Generic;

namespace Altkom.Shop.ViewModels
{

    public class CustomersViewModel : BaseViewModel
    {
        public IEnumerable<Customer> Customers { get; private set; }

        private readonly ICustomerService customerService;

        // ctor
        public CustomersViewModel()
            : this(new FakeCustomerService())
        {

        }

        public CustomersViewModel(ICustomerService customerService)
        {
            this.customerService = customerService;

            Load();
        }

        private void Load()
        {
            Customers = customerService.Get();

        }
    }
}
