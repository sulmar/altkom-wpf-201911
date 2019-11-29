using System.Collections.Generic;
using System.Linq;
using Altkom.Shop.Models;
using Bogus;
using IServices;

namespace FakeServices
{
    public class FakeProductService : FakeEntityService<Product>, IProductService
    {
        public FakeProductService() : base(new ProductFaker())
        {
        }

        public IEnumerable<Product> Get(ProductSearchCriteria criteria)
        {
            var results = entities.AsQueryable();
            
            if (!string.IsNullOrEmpty(criteria.Color))
            {
                results = results.Where(p => p.Color == criteria.Color);
            }

            if (criteria.From.HasValue)
            {
                results = results.Where(p => p.UnitPrice >= criteria.From);
            }

            if (criteria.To.HasValue)
            {
                results = results.Where(p => p.UnitPrice <= criteria.To);
            }

            return results.ToList();


            //    return entities.Where(p=>p.Color == criteria.Color && p.UnitPrice == criteria.From)
        }
    }
}
