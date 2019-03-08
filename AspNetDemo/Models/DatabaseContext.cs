using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetDemo.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DbConnection") { }
        public DbSet<Product> Products { get; set; }
    }
}