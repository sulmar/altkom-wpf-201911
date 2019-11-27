using Altkom.Shop.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace IServices
{
    public interface ICustomerService
    {
        IEnumerable<Customer> Get();
    }
}
