using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantWebApp.Models.DTL;
using RestaurantWebApp.Services;

namespace RestaurantWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Order_MenuItemController : ControllerBase
    {
        // Service Object
        private readonly IOrder_MenuItemService _service;
        
        // Logger
        private readonly ILogger<Order_MenuItemController> _logger;
        
        //Constructor
        public Order_MenuItemController(IOrder_MenuItemService service, ILogger<Order_MenuItemController> logger)
        {
            _service = service;
            _logger = logger;
        }
        
        // Endpoints
        
        
        
    }
}