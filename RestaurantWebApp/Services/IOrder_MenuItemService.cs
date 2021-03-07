using System.Collections.Generic;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public interface IOrder_MenuItemService
    {
        // Should implement business logic for returning all order menu-items
        List<Order_MenuItemDto> GetAllOrder_MenuItems();
    }
}