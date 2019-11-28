using Altkom.Shop.Models;
using Bogus;

namespace FakeServices
{
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.IsRemoved, f => f.Random.Bool(0.2f));
            RuleFor(p => p.City, f => f.Address.City());
            RuleFor(p => p.Photo, f => f.Person.Avatar);
            // Ignore(p => p.City);
        }
    }
}
