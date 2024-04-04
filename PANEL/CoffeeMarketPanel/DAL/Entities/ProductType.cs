using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarketPanel.DAL.Entities
{
	public class ProductType : BaseEntity
	{ 
        public string? TypeName { get; set; }
    }
}
