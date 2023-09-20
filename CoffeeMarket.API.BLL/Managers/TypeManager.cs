using CoffeeMarket.API.BLL.DTO.Response;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Managers
{
	public class TypeManager : ITypeManager
	{
		private ITypeService _typeService;

		public TypeManager(ITypeService typeService)
		{
			_typeService = typeService;
		}

		public async Task<List<CoffeeTypeResponse>> GetAll()
		{

			var response = new List<CoffeeTypeResponse>();
			var res = await _typeService.GetAllAsync();

			foreach (var type in res)
			{
				var newitem = new CoffeeTypeResponse(type);
				response.Add(newitem);
			}
			return response;
		}

		public async Task<CoffeeTypeResponse> GetById(object id)
		{
			var res = await _typeService.GetByIdAsync(id);
			var result = new CoffeeTypeResponse(res);
			return result;
		}

		
	}
}
