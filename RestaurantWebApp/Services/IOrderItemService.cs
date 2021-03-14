using System.Collections.Generic;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public interface IOrderItemService
    {
        // Should implement business logic for returning all order menu-items
        List<OrderItemDto> GetAllOrderItems();

        // Should attempt to create an OrderItem in DB
        bool CreateOrderItem(OrderItemDto orderItem);
    }
}