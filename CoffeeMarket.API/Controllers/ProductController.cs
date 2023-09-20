using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private  ICoffeeManager _coffeeManager;

		public ProductController(ICoffeeManager coffeeManager)
		{
			_coffeeManager = coffeeManager;
		}

		[HttpPost("list")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> List()
		{
			var res = await _coffeeManager.GetAll();
			return new ApiResponse("", new { status = true, data = res }, 200);
		}

		[HttpPost("getCoffee")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> GetCoffeeDetail(string id)
		{
			var res = await _coffeeManager.GetById(id);
			return new ApiResponse("", new { status = true, data = res }, 200);
		}

		
	}
}
