using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public class OrderDao : IOrderDao
    {
        private readonly RestaurantDbContext _context;

        public OrderDao(RestaurantDbContext context)
        {
            _context = context;
        }

        public List<OrderDto> GetAllOrders()
        {
            List<OrderDto> allOrders = _context.Orders.ToList();
            return allOrders;
        }

        public bool CreateOrder(OrderDto order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}