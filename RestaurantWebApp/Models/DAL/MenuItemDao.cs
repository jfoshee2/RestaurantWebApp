using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public class MenuItemDao : IMenuItemDao
    {
        private readonly RestaurantDbContext _context;

        public MenuItemDao(RestaurantDbContext context)
        {
            _context = context;
        }


        public List<MenuItemDto> GetAllMenuItems()
        {
            List<MenuItemDto> allMenuItems = _context.MenuItems.ToList();
            return allMenuItems;
        }
    }
}