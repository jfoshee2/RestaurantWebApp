using System.Collections.Generic;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public interface IMenuItemDao
    {
        // Should return all menu items
        List<MenuItemDto> GetAllMenuItems();
    }
}