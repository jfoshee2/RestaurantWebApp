using System.Collections.Generic;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public interface IOrderItemDao
    {
        // Should return all order_menu-items
        List<OrderItemDto> GetAllOrderItems();
        
        // Should attempt to create an OrderItem in DB
        bool CreateOrderItem(OrderItemDto orderItem);
    }
}