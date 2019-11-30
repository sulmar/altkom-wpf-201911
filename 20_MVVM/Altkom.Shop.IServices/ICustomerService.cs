using Altkom.Shop.Models;
using System.Collections.Generic;

namespace IServices
{
    public interface ICustomerService : IEntityService<Customer>
    {
        IEnumerable<Customer> GetByCity(string city);
    }
}
