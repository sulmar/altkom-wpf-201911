﻿using Altkom.Shop.Models;
using IServices;
using System;
using System.Collections.Generic;

namespace FakeServices
{
    public class DbCustomerService : ICustomerService
    {

        public IEnumerable<Customer> Get()
        {
            throw new NotImplementedException();
        }
    }

    public class FakeCustomerService : ICustomerService
    {
        private readonly IEnumerable<Customer> customers;

        public FakeCustomerService()
        {
            customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Marcin" },   
                new Customer { Id = 2, FirstName = "Marek" },
                new Customer { Id = 3, FirstName = "Sebastian" },
                new Customer { Id = 4, FirstName = "Paweł" },
                new Customer { Id = 5, FirstName = "Mariusz" },
                new Customer { Id = 7, FirstName = "Andrzej" },
                new Customer { Id = 6, FirstName = "Andrzej" },
            };
        }

        public IEnumerable<Customer> Get()
        {
            return customers;
        }
    }
}
