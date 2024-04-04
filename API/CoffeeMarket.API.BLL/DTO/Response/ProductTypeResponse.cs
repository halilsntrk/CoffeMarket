using CoffeMarket.API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Response
{
	public class ProductTypeResponse
	{
        public ProductTypeResponse(ProductType productType)
        {
            id = productType.ID;
            name = productType.TypeName;
        }
        public Guid id { get; set; }
        public string name { get; set; }
    }
}
