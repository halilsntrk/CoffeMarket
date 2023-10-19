using CoffeMarket.API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Response.StockRes
{
	public class StockResponse
	{
        public StockResponse(_Stock stock)
        {
			id = stock.PR_ID;
			productid = stock.PR_ProductID;
			typeid = stock.TypeID;
			stockcount = stock.Stock;
			grammage = stock.Grammage;
			quantity = stock.Quantity;

        }

		public Guid id { get; set; }
		public string productid { get; set; }
		public string typeid { get; set; }
		public int stockcount { get; set; }
		public int grammage { get; set; }
		public int quantity { get; set; }
	}
}
