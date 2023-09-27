using CoffeeMarket.API.BLL.DTO.Request.Product;
using CoffeeMarket.API.BLL.DTO.Response;
using CoffeeMarket.API.BLL.Helpers;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.DAL.Entities;
namespace CoffeeMarket.API.BLL.Managers
{
	public class ProductManager : IProductManager
	{
		private IProductService _productService;
		public ProductManager(IProductService productService)
		{
			_productService = productService;
		}

		//public async Task<ProductResponse> AddProduct(ProductRequest req)
		//{
		//	var response = new ProductResponse(new Product());

		//	var detailImage = await GenericHelper.UploadFileFromBase64(req.detailImage, ".jpg");
		//	var listImage = await GenericHelper.UploadFileFromBase64(req.detailImage, ".jpg");
		//	var product = new Product()
		//	{
		//		PR_ID = Guid.NewGuid(),
		//		PR_ProductID = req.productId,
		//		PR_TypeID = req.typeId,
		//		PR_Name = req.name,
		//		PR_DetailImage = detailImage.url,
		//		PR_ListImage = listImage.url,
		//		PR_Price = req.price,
		//		PR_SpotDetail = req.spotDetail,
		//	};

		//		var res = await _productService.CreateAsync(product);
	

		//	return response;

		//}
		public async Task<List<ProductResponse>> GetAll()
		{
			var response = new List<ProductResponse>();
			var res = await _productService.GetAllAsync();

			foreach (var coffee in res)
			{
				var newitem = new ProductResponse(coffee);
				response.Add(newitem);
			}
			return response;
		}

		public async Task<List<ProductResponse>> GetByTypeId(string typeid)
		{
			var response = new List<ProductResponse>();
			var res = await _productService.GetByTypeId(typeid);

			foreach (var coffee in res)
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
	