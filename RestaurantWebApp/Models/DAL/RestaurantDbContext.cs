using Microsoft.EntityFrameworkCore;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<MenuItemDto> MenuItems { get; set; }
        
        public DbSet<OrderDto> Orders { get; set; }
        
        public DbSet<OrderItemDto> OrderItems { get; set; }
        
        public DbSet<DeliveryOrderDto> DeliveryOrders { get; set; }
    }
}