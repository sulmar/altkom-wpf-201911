using Altkom.Shop.Models;
using IServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Shop.DbServices
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }


        public ShopContext()
            : base("ShopConnection")
        {

        }
    }


    public class DbProductService : IProductService
    {
        private readonly ShopContext context;

        public DbProductService(ShopContext context)
        {
            this.context = context;
        }

        public void Add(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public IEnumerable<Product> Get(ProductSearchCriteria criteria)
        {
            var results = context.Products.AsQueryable();

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
        }

        public IEnumerable<Product> Get()
        {
            return context.Products.ToList();
        }

        public Product Get(int id)
        {
            return context.Products.Find(id);
        }

        public void Remove(int id)
        {
            context.Products.Remove(Get(id));
            context.SaveChanges();
        }

        public void Update(Product entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
