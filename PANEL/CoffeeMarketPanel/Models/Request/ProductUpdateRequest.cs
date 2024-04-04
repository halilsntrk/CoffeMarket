namespace CoffeeMarketPanel.Models.Request
{
    public class ProductUpdateRequest 
    {
        public Guid ID { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
    }
}
