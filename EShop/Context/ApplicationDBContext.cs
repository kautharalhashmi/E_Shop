using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EShop.Context
{
    public class ApplicationDBContext : DbContext
    {

        //Dbsets
        public DbSet<Customer> Customer_tb { get; set; }
        public DbSet<Product> Product_tb { get; set; }
        public DbSet<Order> Order_tb { get; set; }
        public DbSet<OrderItem> OrderItem_tb { get; set; }
        public DbSet<Category> Category_tb { get; set; }
        public DbSet<PaymentInformation> Payment_tb { get; set; }
        public DbSet<ShippingAddress> Shipping_tb { get; set; }
        public DbSet<Review> Review_tb { get; set; }

        //onconfigure
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");

        }
    }
}
