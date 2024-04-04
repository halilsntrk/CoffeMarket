using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.DTO.Request.Product;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;

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


		[HttpGet("list")]
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


        [HttpGet("search")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        public async Task<ApiResponse> Search(string searchkey)
        {
			if (searchkey.Length>3)
			{
                var res = await _productManager.GetAll();
                res = res.Where(t => t.name.ToLower().Contains(searchkey.ToLower()) | t.spotDetail.ToLower().Contains(searchkey.ToLower())).ToList();
                return new ApiResponse("", new { status = true, data = res }, 200);
            }
            return new ApiResponse("", new { status = false, data = "" }, 200);

        }


        //[HttpPost("createProduct")]
        //[ProducesResponseType(typeof(ApiResponse), 200)]
        //public async Task<ApiResponse> CreateNewProduct(ProductRequest product)
        //{
        //	var res = await _productManager.Create(product);
        //	return new ApiResponse("", new { status = true, data = res }, 200);
        //}


    }
}
