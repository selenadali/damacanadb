﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace damacanadb.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public List<Product> cartproducts { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class CartDBContext : DbContext
    {
        public DbSet<Cart> carts { get; set; }
    }
}