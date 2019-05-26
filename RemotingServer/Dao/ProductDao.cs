using System;
using System.Collections.Generic;
using RemotingLibrary.Models;
using Org.Mql.Ado;
using System.Data;
using RemotingLibrary.Dao;

namespace RemotingServer.Dao
{
    public class ProductDao : MarshalByRefObject, IProductDao
    {
        SqlDataBase sql = new SqlDataBase(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public ProductDao()
        {
            Console.WriteLine("==> New connection.");
        }

        public Product FindById(int id)
        {
            DataRow item = sql.FindById("Products", id);
            Product product = new Product();

            product.Id = int.Parse(item["ID"].ToString());
            product.Price = double.Parse(item["Price"].ToString());
            product.Description = item["Description"].ToString();
            product.Label = item["Label"].ToString();
            product.Quantity = int.Parse(item["Quantity"].ToString());
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