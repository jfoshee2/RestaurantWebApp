namespace RestaurantWebApp.Models.DTL
{
    // Data Transfer Object Container Class for Orders
    public class OrderDto
    {
        public OrderDto(int id, string orderType, string orderName)
        {
            ID = id;
            OrderType = orderType;
            OrderName = orderName;
        }

        public OrderDto()
        {
        }

        public int ID { get; set; }

        public string OrderType { get; set; }

        public string OrderName { get; set; }
        
    }
}