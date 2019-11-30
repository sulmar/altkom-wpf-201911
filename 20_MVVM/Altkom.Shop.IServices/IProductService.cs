using Altkom.Shop.Models;
using System.Collections;
using System.Collections.Generic;

namespace IServices
{
    public interface IProductService : IEntityService<Product>
    {
        IEnumerable<Product> Get(ProductSearchCriteria criteria);
    }
}
