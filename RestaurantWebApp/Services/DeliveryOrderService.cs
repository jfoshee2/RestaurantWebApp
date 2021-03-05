using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DAL;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public class DeliveryOrderService : IDeliveryOrderService
    {
        // Database Access Object
        private readonly IDeliveryOrderDao _dao;
        
        // Constructor
        public DeliveryOrderService(IDeliveryOrderDao dao)
        {
            _dao = dao;
        }
        
    }
}