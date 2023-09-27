using CoffeMarket.API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Response
{
	public class ProductCategoryResponse
	{
        public ProductCategoryResponse(ProductCategory category)
        {
            productid = category.ProductID;
            categoryname = category.CategoryName;
            typeid = category.TypeID;
        }

        public Guid productid { get; set; }
        public string typeid { get; set; }
        public string categoryname { get; set; }
    }
}
