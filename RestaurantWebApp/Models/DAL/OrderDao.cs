using System.Collections.Generic;
using System.Linq;
using RestaurantWebApp.Models.DTL;

namespace RestaurantWebApp.Models.DAL
{
    public class OrderDao : IOrderDao
    {
        private readonly RestaurantDbContext _context;

        public OrderDao(RestaurantDbContext context)
        {
            _context = context;
        }
        
    }
}