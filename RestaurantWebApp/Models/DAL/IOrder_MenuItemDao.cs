using System.Collections.Generic;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public interface IOrder_MenuItemDao
    {
        // Should return all order_menu-items
        List<Order_MenuItemDto> GetAllOrder_MenuItems();
    }
}