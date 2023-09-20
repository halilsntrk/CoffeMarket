using CoffeeMarket.API.BLL.DTO.Response;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;

namespace CoffeeMarket.API.BLL.Managers
{
	public class CoffeManager : ICoffeeManager
	{
		private readonly ICoffeeService _coffeeService;
		public CoffeManager(ICoffeeService coffeeService)
		{
			_coffeeService = coffeeService;
		}

		public async Task<List<CoffeeResponse>> GetAll()
		{
			var response = new List<CoffeeResponse>();
			var res = await _coffeeService.GetAllAsync();

			foreach ( var item in res)
			{
				var newitem = new CoffeeResponse();
				response.Add(newitem);
			}
			return response;
		}


	}
}
