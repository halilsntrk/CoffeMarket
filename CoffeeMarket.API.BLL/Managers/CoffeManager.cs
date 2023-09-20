using CoffeeMarket.API.BLL.DTO.Response;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;

namespace CoffeeMarket.API.BLL.Managers
{
	public class CoffeManager : ICoffeeManager
	{
		private  ICoffeeService _coffeeService;
		public CoffeManager(ICoffeeService coffeeService)
		{
			_coffeeService = coffeeService;
		}

		public async Task<List<CoffeeResponse>> GetAll()
		{
			var response = new List<CoffeeResponse>();
			var res = await _coffeeService.GetAllAsync();

			foreach ( var coffee in res)
			{
				var newitem = new CoffeeResponse(coffee);
				response.Add(newitem);
			}
			return response;
		}

		public async Task<CoffeeResponse> GetById(object id)
		{
			var res = await _coffeeService.GetByIdAsync(id);
			var result = new CoffeeResponse(res);
			return result;

		}
	}
}
