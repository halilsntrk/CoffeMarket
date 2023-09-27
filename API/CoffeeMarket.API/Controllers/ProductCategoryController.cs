using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductCategoryController : ControllerBase
	{
		private readonly ICategoryManager _categoryManager;

		public ProductCategoryController(ICategoryManager categoryManager)
		{
			_categoryManager = categoryManager;
		}

		[HttpPost("list")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> List()
		{
			var res = await _categoryManager.GetAll();
			return new ApiResponse("", new { status = true, data = res }, 200);
		}


		[HttpPost("getwithtype")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> GetCategoryWithType(string typeID)
		{
			var res = await _categoryManager.GetByTypeId(typeID);
			return new ApiResponse("", new { status = true, data = res }, 200);
		}

	}
}
