namespace RestaurantWebApp.Models.DTL
{
    // Data Transfer Object Container Class for Orders_MenuItems
    public class OrderItemDto
    {
        public OrderItemDto(int id, int orderID, int menuItemID, string customerInstructions)
        {
            ID = id;
            OrderID = orderID;
            MenuItemID = menuItemID;
            CustomerInstructions = customerInstructions;
        }

        public OrderItemDto()
        {
        }

        public int ID { get; set; }
        
        public int OrderID { get; set; }
        
        public int MenuItemID { get; set; }
        
        public string CustomerInstructions { get; set; }
    }
}