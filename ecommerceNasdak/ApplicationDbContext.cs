namespace ecommerceNasdak
{
    using ecommerceNasdak.Models;
    // Data/ApplicationDbContext.cs
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<ShopOrder> ShopOrders { get; set; }
        public DbSet<ShopOrderDetail> ShopOrderDetails { get; set; }
    }
}
