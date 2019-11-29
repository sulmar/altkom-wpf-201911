using Altkom.Shop.Models;
using IServices;
using System;
using System.Collections.Generic;

namespace DbServices
{
    // 1. ADO.NET ExecuteReader
    /*
     
    private static void CreateCommand(string queryString,
    string connectionString)
{
    using (SqlConnection connection = new SqlConnection(
               connectionString))
    {
        connection.Open();

        SqlCommand command = new SqlCommand(queryString, connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine(String.Format("{0}", reader[0]));
        }
    }
}
*/

    // 2. Dapper


    // 3. Entity Framework


   public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }

    public class DbProductService : IProductService
    {
        private ShopContext context;


        public void Add(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public IEnumerable<Product> Get(ProductSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            return context.Products.ToList();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            context.Remove(Get(id));
            context.SaveChanges();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
