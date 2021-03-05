using Microsoft.EntityFrameworkCore;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<MenuItemDto> MenuItems { get; set; }
        
        public DbSet<OrderDto> Orders { get; set; }
        
        public DbSet<Order_MenuItemDto> Order_MenuItems { get; set; }
        
        public DbSet<DeliveryOrderDto> DeliveryOrders { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Specifies when creating Order_MenuItemDTO's that OrderID and MenuItemID are both Keys
            modelBuilder.Entity<Order_MenuItemDto>().HasKey(omi => new { omi.OrderID, omi.MenuItemID });      
        }
    }
}