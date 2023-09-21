using CoffeeMarket.API.BLL.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Managers
{
	public interface ITypeManager
	{
		public Task<List<ProductTypeResponse>> GetAll();

		public Task<ProductTypeResponse> GetById(object id);
	}
}
