using System.Collections.Generic;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public interface IMenuItemService
    {
        // Should implement business logic for returning all menu items
        List<MenuItemDto> GetAllMenuItems();
    }
}