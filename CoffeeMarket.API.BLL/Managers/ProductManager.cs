using CoffeeMarket.API.BLL.DTO.Response;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;

namespace CoffeeMarket.API.BLL.Managers
{
	public class ProductManager : IProductManager
	{
		private  IProductService _productService;
		public ProductManager(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<List<ProductResponse>> GetAll()
		{
			var response = new List<ProductResponse>();
			var res = await _productService.GetAllAsync();

			foreach ( var coffee in res)
			{
				var newitem = new ProductResponse(coffee);
				response.Add(newitem);
			}
			return response;
		}

		public async Task<ProductResponse> GetById(object id)
		{
			var res = await _productService.GetByIdAsync(id);
			var result = new ProductResponse(res);
			return result;

		}
	}
}
