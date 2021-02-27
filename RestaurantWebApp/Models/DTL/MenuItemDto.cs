namespace RestaurantWebApp.Models.DTL
{
    // Data Transfer Object Container Class for Menu Items
    public class MenuItemDto
    {
        public MenuItemDto(int id, string itemName, string imageURL, float price)
        {
            ID = id;
            ItemName = itemName;
            ImageURL = imageURL;
            Price = price;
        }

        public MenuItemDto()
		{

		}

        public int ID { get; set; }

        public string ItemName { get; set; }

        public string ImageURL { get; set; }

        public float Price { get; set; }
    }
}