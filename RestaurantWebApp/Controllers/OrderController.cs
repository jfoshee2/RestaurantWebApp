using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantWebApp.Models.DTL;
using RestaurantWebApp.Services;

namespace RestaurantWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        // Service Object
        private readonly IOrderService _service;
        
        // Logger
        private readonly ILogger<OrderController> _logger;
        
        //Constructor
        public OrderController(IOrderService service, ILogger<OrderController> logger)
        {
            _service = service;
            _logger = logger;
        }

        // Endpoints

        // "GET /api/Order/"
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.GetAllOrders().ToArray();
            return Ok(result);
        }

    }
}