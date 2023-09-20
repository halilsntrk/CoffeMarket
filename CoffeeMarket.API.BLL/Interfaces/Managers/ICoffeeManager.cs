using CoffeeMarket.API.BLL.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Managers
{
	public interface ICoffeeManager
	{
		public  Task<List<CoffeeResponse>> GetAll();

		public Task<CoffeeResponse> GetById(object id);
	}
}
