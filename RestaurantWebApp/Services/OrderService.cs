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
        
    }
}