using System.Collections.Generic;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public interface IOrderDao
    {
        // Should return all orders
        List<OrderDto> GetAllOrders();
    }
}