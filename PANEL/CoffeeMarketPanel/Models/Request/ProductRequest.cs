using CoffeeMarketPanel.Models.Common;
using static System.Net.Mime.MediaTypeNames;

namespace CoffeeMarketPanel.Models.Request
{
    public class ProductRequest
    {
        public string? ProductID { get; set; }
        public string? TypeID { get; set; }
        public string? Name { get; set; }
        public int? Grammage { get; set; }
        public int? Price { get; set; }
        public IFormFile? ListImage { get; set; }
        public IFormFile? DetailImage { get; set; }
        public string? Spot { get; set; }


    }
}
