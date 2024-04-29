using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
	[Route("/[controller]")]
	[ApiController]
	public class StockController : ControllerBase
	{
		private IStockManager _stockManager;

		public StockController(IStockManager stockManager)
		{
			_stockManager = stockManager;
		}

		[HttpPost("list")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> List()
		{
			var res = await _stockManager.GetAll();
			return new ApiResponse("", new { status = true, data = res }, 200);
		}
	}
}
