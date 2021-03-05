using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public class Order_MenuItemDao : IOrder_MenuItemDao
    {
        private readonly RestaurantDbContext _context;

        public Order_MenuItemDao(RestaurantDbContext context)
        {
            _context = context;
        }
        
        public List<Order_MenuItemDto> GetAllOrder_MenuItems()
        {
            List<Order_MenuItemDto> allOrder_MenuItems = _context.Order_MenuItems.ToList();
            return allOrder_MenuItems;
        }
    }
}