using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DAL;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public class OrderService : IOrderService
    {
        // Database Access Object
        private readonly IOrderDao _dao;
        
        // Constructor
        public OrderService(IOrderDao dao)
        {
            _dao = dao;
        }

        // Returns all Orders in DB
        public List<OrderDto> GetAllOrders()
        {
            var result = _dao.GetAllOrders();
            return result;
        }

        // Returns attempts to create order in DB
        public bool CreateOrder(OrderDto order)
        {
            if (order.OrderType != "PICKUP" && order.OrderType != "DINEIN" && order.OrderType != "DELIVERY")
            {
                return false;
            }
            else
            {
                return _dao.CreateOrder(order);
            }
        }
    }
}