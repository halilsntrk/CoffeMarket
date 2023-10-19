using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMarket.API.DAL.Entities
{
	public class _Stock : EntityBase
	{
        public Guid PR_ID { get; set; }
        public string PR_ProductID { get; set; }
        public string TypeID { get; set; }
        public int Stock { get; set; }
        public int Grammage { get; set; }
        public int Quantity { get; set; }
    }
}
