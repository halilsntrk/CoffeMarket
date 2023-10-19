using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Request.Order
{
	public class OrderRequest
	{
        public Guid id { get; set; }
        public string orderid { get; set; }
        public List<string> productid { get; set; }
        public DateTime orderdate { get; set; }
        public int quantity { get; set; }
        public int amount { get; set; }
       
    }
}
