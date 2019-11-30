using Altkom.Shop.Models;
using Bogus;
using IServices;
using System.Collections.Generic;
using System.Linq;

namespace FakeServices
{
    public class FakeEntityService<TEntity> : IEntityService<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly ICollection<TEntity> entities;

        private Faker<TEntity> faker;

        public FakeEntityService(Faker<TEntity> faker)
        {
            this.faker = faker;

            entities = faker.Generate(100);
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }

        public IEnumerable<TEntity> Get()
        {
            return entities;
        }

        public TEntity Get(int id)
        {
            return entities.SingleOrDefault(e=>e.Id == id);
        }

        public void Remove(int id)
        {
            entities.Remove(Get(id));
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
