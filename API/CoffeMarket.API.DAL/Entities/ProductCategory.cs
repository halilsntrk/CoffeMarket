using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMarket.API.DAL.Entities
{
	public class ProductCategory
	{
        public Guid ID { get; set; }
        public string TypeID { get; set; }
        public string CategoryName { get; set; }
    }
}
