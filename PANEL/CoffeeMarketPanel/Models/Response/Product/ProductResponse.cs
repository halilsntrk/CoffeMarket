namespace CoffeeMarketPanel.Models.Response.Product
{
    public class ProductResponse
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string price { get; set; }
        public string grammage { get; set; }
        public string stock { get; set; }
        public string imageurl { get; set; }
    }
}
