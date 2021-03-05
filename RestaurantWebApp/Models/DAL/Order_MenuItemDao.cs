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
        
    }
}