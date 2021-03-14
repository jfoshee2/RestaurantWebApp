using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DAL;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public class OrderItemService : IOrderItemService
    {
        // Database Access Object
        private readonly IOrderItemDao _dao;
        
        // Constructor
        public OrderItemService(IOrderItemDao dao)
        {
            _dao = dao;
        }
        
        // Returns all OrderItems in DB
        public List<OrderItemDto> GetAllOrderItems()
        {
            var result = _dao.GetAllOrderItems();
            return result;
        }

        // Creates OrderItem in DB
        public bool CreateOrderItem(OrderItemDto orderItem)
        {
            var result = _dao.CreateOrderItem(orderItem);
            return result;
        }
    }
}