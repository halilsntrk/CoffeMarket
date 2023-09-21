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
		public  Task<List<ProductResponse>> GetAll();

		public Task<ProductResponse> GetById(object id);
	}
}
