using Microsoft.EntityFrameworkCore;
using OrderTrackingApi.Models;

namespace OrderTrackingApi.Data
{
    public class OrderTrackingContext : DbContext
    {
        public OrderTrackingContext(DbContextOptions<OrderTrackingContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
