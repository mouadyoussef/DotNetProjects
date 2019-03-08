using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AspNetDemo.Models;

namespace AspNetDemo.Dao
{
    public class ProductDao : IProductDao
    {
        private DatabaseContext _context { get; }

        public ProductDao()
        {
            _context = new DatabaseContext();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product Delete(int id)
        {
            Product product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return product;
        }

        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }

        public IList<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public IList<Product> GetProducts(string name)
        {
            var result = from p in _context.Products
                         where p.Name.Contains(name)
                         select p;
            return result.ToList();
        }

        public void Update(Product product)
        {
            _context.Products.Add(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IList<Product> GetByMaxPrice(double price)
        {
            return _context.Products.Where(p => p.Price < price).OrderBy(p => p.Name).ToList();
        }
    }
}