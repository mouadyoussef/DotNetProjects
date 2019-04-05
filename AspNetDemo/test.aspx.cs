using AspNetDemo.Dao;
using AspNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetDemo
{
    public partial class test : System.Web.UI.Page
    {
        IProductDao _productDao = new ProductDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            IQueryable<Product> products = _productDao.GetProducts();
            Application["products"] = products;
        }

        protected void Test_Click(object sender, EventArgs e)
        {
            //IEnumerable<Product> products = _productDao.GetProducts(tbTest.Text);
            IQueryable<Product> products = _productDao.GetProducts(tbTest.Text);
            Application["products"] = products;
            //foreach (Product item in products)
            //{
            //    Application["value"] += item.ToString() + "<br/>";
            //}
        }

        public IQueryable<Product> productsGrid_GetData()
        {
            return _productDao.GetProducts();
        }
    }
}