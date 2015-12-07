using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace damacanadb.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Product> purchaselist { get; set; }
        public decimal TotalPrice { get; set; }

    }
    public class PurchaseDBContext : DbContext
    {
        public DbSet<Purchase> purchases { get; set; }
    }
}