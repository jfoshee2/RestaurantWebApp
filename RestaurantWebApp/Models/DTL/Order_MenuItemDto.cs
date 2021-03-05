namespace RestaurantWebApp.Models.DTL
{
    // Data Transfer Object Container Class for Orders_MenuItems
    public class Order_MenuItemDto
    {
        public Order_MenuItemDto(int orderID, int menuItemID, string customerInstructions)
        {
            OrderID = orderID;
            MenuItemID = menuItemID;
            CustomerInstructions = customerInstructions;
        }

        public Order_MenuItemDto()
        {
        }

        public int OrderID { get; set; }
        
        public int MenuItemID { get; set; }
        
        public string CustomerInstructions { get; set; }
    }
}