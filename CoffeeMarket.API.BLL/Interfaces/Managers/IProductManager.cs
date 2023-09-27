using CoffeeMarket.API.BLL.DTO.Request.Product;
using CoffeeMarket.API.BLL.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Managers
{
	public interface IProductManager
	{
		//public Task<ProductResponse> AddProduct(ProductRequest req);
		public  Task<List<ProductResponse>> GetAll();
		public Task<List<ProductResponse>> GetByTypeId(string typeId);
		public Task<ProductResponse> GetById(object id);
	}
}
