using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eshop_bookstore.Models;

namespace Eshop_bookstore.Data
{
    public class Eshop_bookstoreContext : DbContext
    {
        public Eshop_bookstoreContext (DbContextOptions<Eshop_bookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<Eshop_bookstore.Models.Accounts> Accounts { get; set; }

        public DbSet<Eshop_bookstore.Models.Cart> Cart { get; set; }

        public DbSet<Eshop_bookstore.Models.InvoiceDetails> InvoiceDetails { get; set; }

        public DbSet<Eshop_bookstore.Models.Invoices> Invoices { get; set; }

        public DbSet<Eshop_bookstore.Models.Products> Products { get; set; }

        public DbSet<Eshop_bookstore.Models.ProductTypes> ProductTypes { get; set; }
    }
}
