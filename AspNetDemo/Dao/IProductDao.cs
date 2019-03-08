using AspNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetDemo.Dao
{
    interface IProductDao
    {
        void Add(Product product);
        void Update(Product product);
        Product Delete(int id);
        Product Get(int id);
        IList<Product> GetProducts();
        IList<Product> GetProducts(string name);
        IList<Product> GetByMaxPrice(double price);
    }
}
