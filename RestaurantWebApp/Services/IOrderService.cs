using System.Collections.Generic;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public interface IOrderService
    {
        // Should implement business logic for returning all orders
        List<OrderDto> GetAllOrders();
    }
}