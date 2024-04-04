using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarketPanel.DAL.Entities
{
	public class ProductCategory : BaseEntity
	{
        public string TypeID { get; set; }
        public string? CategoryName { get; set; }
    }
}
