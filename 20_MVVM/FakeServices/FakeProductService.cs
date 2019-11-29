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
    }
}
