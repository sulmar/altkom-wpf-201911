using Altkom.Shop.Models;
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
}
