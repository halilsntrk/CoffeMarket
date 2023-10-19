using CoffeeMarket.API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Request.Product
{
    public class ProductRequest
    {

        public string typeId { get; set; }
        public string name { get; set; }
        public string grammage { get; set; }
        public string price { get; set; }
        public string listImage { get; set; }
        public string detailImage { get; set; }
        public string spotDetail { get; set; }
    }
}

