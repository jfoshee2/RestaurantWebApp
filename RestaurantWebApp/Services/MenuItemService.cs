using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DAL;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public class MenuItemService : IMenuItemService
    {
        // Database Access Object
        private readonly IMenuItemDao _dao;
        
        // Constructor
        public MenuItemService(IMenuItemDao dao)
        {
            _dao = dao;
        }
        
        // Returns all MenuItems in DB
        public List<MenuItemDto> GetAllMenuItems()
        {
            var result = _dao.GetAllMenuItems();
            return result;
        }
    }
}