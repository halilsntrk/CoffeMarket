using CoffeeMarket.API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Response
{
	public class ProductResponse
	{
        public ProductResponse(Product product)
        {
            id = product.PR_ID;
            productId = product.PR_ProductID;
            typeId = product.PR_TypeID;
            name = product.PR_Name;
            grammage = product.PR_Grammage;
            price = product.PR_Price;
            listImage = product.PR_ListImage;
            detailImage = product.PR_DetailImage;
            spotDetail = product.PR_SpotDetail;
        }
        public Guid id { get; set; }
        public string productId { get; set; }
        public string typeId { get; set; }
        public string name { get; set; }
        public string grammage { get; set; }
        public string price { get; set; }
        public string listImage { get; set; }
        public string detailImage { get; set; }
        public string spotDetail { get; set; }
    }
}
