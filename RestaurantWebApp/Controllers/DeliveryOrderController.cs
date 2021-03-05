using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantWebApp.Models.DTL;
using RestaurantWebApp.Services;

namespace RestaurantWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryOrderController : ControllerBase
    {
        // Service Object
        private readonly IDeliveryOrderService _service;
        
        // Logger
        private readonly ILogger<DeliveryOrderController> _logger;
        
        //Constructor
        public DeliveryOrderController(IDeliveryOrderService service, ILogger<DeliveryOrderController> logger)
        {
            _service = service;
            _logger = logger;
        }
        
        // Endpoints
        
        
        
    }
}