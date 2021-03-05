using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public class DeliveryOrderDao : IDeliveryOrderDao
    {
        private readonly RestaurantDbContext _context;

        public DeliveryOrderDao(RestaurantDbContext context)
        {
            _context = context;
        }
        
    }
}