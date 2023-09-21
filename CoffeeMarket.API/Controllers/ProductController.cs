using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private  IProductManager _productManager;

		public ProductController(IProductManager productManager)
		{
			_productManager = productManager;
		}

		[HttpPost("list")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> List()
		{
			var res = await _productManager.GetAll();
			return new ApiResponse("", new { status = true, data = res }, 200);
		}

		[HttpPost("getProduct")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> GetProducteDetail(string id)
		{
			var res = await _productManager.GetById(id);
			return new ApiResponse("", new { status = true, data = res }, 200);
		}

		
	}
}
