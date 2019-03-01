using System;
using System.Collections.Generic;
using RemotingLibrary.Models;
using Org.Mql.Ado;
using System.Data;

namespace RemotingLibrary.Dao
{
    public class ProductDao : MarshalByRefObject, IProductDao
    {
        SqlDataBase sql = new SqlDataBase(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Product Find()
        {
            return new Product { Id = 1, Label = "Huawei Y9", Price = 2600.0, Description = "Desc", Quantity = 25 };
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            foreach(DataRow item in sql.Select("Products").Rows)
            {
                Product p = new Product {Id = int.Parse(item["ID"].ToString()) };
                p.Description = item["Description"].ToString();
                p.Price = double.Parse(item["Price"].ToString());
                p.Label = item["Label"].ToString();
                p.Quantity = int.Parse(item["Quantity"].ToString());
                products.Add(p);
            }
            return products;
        }
    }
}