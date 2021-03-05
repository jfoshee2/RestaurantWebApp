namespace RestaurantWebApp.Models.DTL
{
    // Data Transfer Object Container Class for DeliveryOrders
    public class DeliveryOrderDto
    {
        public DeliveryOrderDto(int id, int orderID, string streetAddress, string city, string state, string zipCode, string apartmentNumber, string additionalInstructions)
        {
            ID = id;
            OrderID = orderID;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
            ApartmentNumber = apartmentNumber;
            AdditionalInstructions = additionalInstructions;
        }

        public DeliveryOrderDto()
        {
        }

        public int ID { get; set; }
        
        public int OrderID { get; set; }
        
        public string StreetAddress { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public string ZipCode { get; set; }
        
        public string ApartmentNumber { get; set; }
        
        public string AdditionalInstructions { get; set; }
    }
}