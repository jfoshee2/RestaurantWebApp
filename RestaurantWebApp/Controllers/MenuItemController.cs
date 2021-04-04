using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using RestaurantWebApp.Models.DTL;
using RestaurantWebApp.Services;

namespace RestaurantWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuItemController : ControllerBase
    {
        // Service Object
        private readonly IMenuItemService _service;
        
        // Logger
        private readonly ILogger<MenuItemController> _logger;
        
        //Constructor
        public MenuItemController(IMenuItemService service, ILogger<MenuItemController> logger)
        {
            _service = service;
            _logger = logger;
        }
        
        // Endpoints
        
        // "GET /api/menuitem/"
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.GetAllMenuItems().ToArray();
            return Ok(result);
        }
        
        // "POST /api/menuitem/"
        [HttpPost]
        public IActionResult CreateMenuItem(MenuItemDto item)
        {
            return _service.CreateMenuItem(item) ? (IActionResult) Ok() : BadRequest();
        }
    }
}