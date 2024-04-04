using CoffeeMarketPanel.Models.GeneralResponse;
using CoffeeMarketPanel.Models.Request;
using CoffeeMarketPanel.Models.Response.Product;
using Microsoft.AspNetCore.Mvc;
using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Authorization;
using CoffeeMarketPanel.Business.Abstract.Product;
using Treblle.Net.Core;
using CoffeeMarketPanel.Models.Common;

namespace CoffeeMarketPanel.Controllers
{
   

    [Authorize]
    public class ProductController(IProductService _productService) : Controller
    {

        [HttpPost("/add")]
        public async Task<ApiResponse> AddProduct([FromForm]ProductRequest req)
        {
            if (!ModelState.IsValid)
            {
                return new ApiResponse { StatusCode = 200, Result = null, Message = "Ürün biçimi hatalı"};
            }

            var response = await _productService.Create(req);

            return new ApiResponse { StatusCode = 200, Result = response.data, Message = response.message };

        }

        [HttpPost("/update")]
        public async Task<ApiResponse> UpdateProduct([FromBody]ProductUpdateRequest req)
        {

            var response = await _productService.Update(req);
            return new ApiResponse { StatusCode = 200, Result = response.data, Message = response.message};

        }

        [Treblle]
        [HttpGet("/list")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        public async Task<ApiResponse> List()
        {
            var response = await _productService.GetProducts();

            return new ApiResponse { StatusCode = 200, Result = response };
        }

        [Route("/delete/{id}", Name = "deleteproduct")]
        public async Task<ApiResponse> Delete(Guid id)
        {

            var response = await _productService.Delete(id);

            return new ApiResponse { StatusCode = 200, Result = response.data, Message = response.message };
        }
        [Treblle]
        [HttpGet("/getproduct")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        public async Task<ApiResponse> Detail(Guid id)
        {
            var response = await _productService.GetProductById(id);


            return new ApiResponse { StatusCode = 200, Result = response.data, Message = response.message };
        }


        [HttpPost("softUpload")]
        public async Task<ApiResponse> Upload(IFormFile image)
        {
            var response = new Image(image);


            return new ApiResponse { StatusCode = 200, Result = response };
        }
    }
}
