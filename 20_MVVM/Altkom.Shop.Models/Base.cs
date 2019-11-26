using System;

namespace Altkom.Shop.Models
{
    public abstract class Base
    {
    }

    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {

    }

}
