using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public class OrderItemDao : IOrderItemDao
    {
        private readonly RestaurantDbContext _context;

        public OrderItemDao(RestaurantDbContext context)
        {
            _context = context;
        }
        
        public List<OrderItemDto> GetAllOrderItems()
        {
            List<OrderItemDto> orderItems = _context.OrderItems.ToList();
            return orderItems;
        }

        public bool CreateOrderItem(OrderItemDto orderItem)
        {
            try
            {
                _context.OrderItems.Add(orderItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}