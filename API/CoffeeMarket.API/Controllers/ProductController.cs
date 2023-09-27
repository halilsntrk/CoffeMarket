using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.DTO.Request.Product;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.DAL.Entities;
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


		//[HttpPost("add")]
		//[ProducesResponseType(typeof(ApiResponse), 200)]
		//public async Task<ApiResponse> AddProduct(ProductRequest req)
		//{
		//	var res = await _productManager.AddProduct(req);
		//	return new ApiResponse("", new { status = true, data = res }, 200);
		//}


		[HttpPost("list")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> List()
		{
			var res = await _productManager.GetAll();
			return new ApiResponse("", new { status = true, data = res }, 200);
		}

		[HttpPost("getwithtype")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> GetProductWithType(string typeID)
		{
			var res = await _productManager.GetByTypeId(typeID);
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
