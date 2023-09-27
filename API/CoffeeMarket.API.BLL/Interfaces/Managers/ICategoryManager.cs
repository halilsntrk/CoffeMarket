using CoffeeMarket.API.BLL.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Managers
{
	public interface ICategoryManager
	{
		public Task<List<ProductCategoryResponse>> GetAll();
		public Task<List<ProductCategoryResponse>> GetByTypeId(string typeId);
	
	}
}
