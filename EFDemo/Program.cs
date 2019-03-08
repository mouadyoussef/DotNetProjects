using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsContext context = new ProductsContext();
            Product product = new Product() { Label = "Product 9", Description = "Desc 4", Price = 1200, Quantity = 30 };
            context.Products.Add(product);
            context.SaveChanges();

            var result =
                from p in context.Products
                where p.Price > 5000
                orderby p.Price
                select p;

            //var result2 = context.Products.Where(p => p.Price > 5000).OrderBy(p => p.Label);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id} - {item.Label} ==> {item.Price}");
            }

            Console.ReadKey();
        }
    }

    class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductsContext() : base("name=DbConnection") { }
    }
}
