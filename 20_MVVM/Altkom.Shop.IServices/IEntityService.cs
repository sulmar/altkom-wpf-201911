using Altkom.Shop.Models;
using System.Collections.Generic;

namespace IServices
{
    // DRY = Don't repeat yourself!

    // Interfejs generyczny
    public interface IEntityService<TEntity>
        where TEntity : BaseEntity
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
