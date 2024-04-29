using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.DTO.Request.Order;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
	[Route("/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private IOrderManager _orderManager;

		public OrderController(IOrderManager orderManager)
		{
			_orderManager = orderManager;
		}

		//[HttpGet("list")]
		//[ProducesResponseType(typeof(ApiResponse), 200)]
		//public async Task<ApiResponse> List()
		//{
		//	var res = await _orderManager.);
		//	return new ApiResponse("", new { status = true, data = res }, 200);
		//}

		[HttpPost("create")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> Create(OrderRequest request)
		{
			var res = await _orderManager.Create(request);
			return new ApiResponse("", new { status = true, data = res }, 200);
		}
	}
}
