using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantWebApp.Models.DTL;
using RestaurantWebApp.Services;

namespace RestaurantWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ControllerBase
    {
        // Service Object
        private readonly IOrderItemService _service;
        
        // Logger
        private readonly ILogger<OrderItemController> _logger;
        
        //Constructor
        public OrderItemController(IOrderItemService service, ILogger<OrderItemController> logger)
        {
            _service = service;
            _logger = logger;
        }
        
        // Endpoints
        
        // "GET /api/orderItem/"
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.GetAllOrderItems().ToArray();
            return Ok(result);
        }
        
        // "POST /api/orderItem/"
        [HttpPost]
        public IActionResult Create(OrderItemDto orderItem)
        {
            return _service.CreateOrderItem(orderItem) ? (IActionResult) Ok() : BadRequest();
        }
        
    }
}