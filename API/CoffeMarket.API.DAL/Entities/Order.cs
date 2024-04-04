using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMarket.API.DAL.Entities
{
	public class Order
	{
        public Guid ID { get; set; }
		public string OR_OrderID { get; set; }
		public List<string> PR_ProductID { get; set; }
		public DateTime OR_OrderDate { get; set; }
		public int Quantity { get; set; }
		public int Amount { get; set; }
		public string State_Slug { get; set; }

	
	}
}
