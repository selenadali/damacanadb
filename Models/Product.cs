using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace damacanadb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> products { get; set; }
    }
}