using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMarket.API.DAL.Entities
{
	public class CoffeeType
	{
        public Guid TypeID { get; set; }
        public string TypeName { get; set; }
    }
}
