﻿using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DAL;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Services
{
    public class Order_MenuItemService : IOrder_MenuItemService
    {
        // Database Access Object
        private readonly IOrder_MenuItemDao _dao;
        
        // Constructor
        public Order_MenuItemService(IOrder_MenuItemDao dao)
        {
            _dao = dao;
        }
        
    }
}