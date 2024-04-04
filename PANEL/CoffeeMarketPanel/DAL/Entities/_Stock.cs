using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarketPanel.DAL.Entities
{
	public class _Stock : BaseEntity
	{
        public string PR_ProductID { get; set; }
        public string TypeID { get; set; }
        public int Stock { get; set; }
        public int Grammage { get; set; }
        public int Quantity { get; set; }
    }
}
