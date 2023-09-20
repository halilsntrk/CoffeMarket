using CoffeeMarket.API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Response
{
	public class CoffeeResponse
	{
        public CoffeeResponse(Coffee coffee)
        {
            id = coffee.PR_ID;
            name = coffee.PR_Name;
            price = coffee.PR_Price;
            listImage = coffee.PR_ListImage;
            detailImage = coffee.PR_DetailImage;
            
        }
        public Guid id { get; set; }
		public string name { get; set; }
        public string price { get; set; }
        public string listImage { get; set; }
        public string detailImage { get; set; }
    }
}
