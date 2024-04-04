using AutoWrapper.Wrappers;
using CoffeeMarketPanel.Business.Abstract.ProductType;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarketPanel.Controllers
{
    public class ProductTypeController(IProductTypeService _typeService) 
    {
    
        [HttpGet("/gettypes")]
        public async Task<ApiResponse> GetTypes()
        {
            var response = await _typeService.GetProductTypes();

            return new ApiResponse { StatusCode = 200, Result = response };
        }
    }
}
