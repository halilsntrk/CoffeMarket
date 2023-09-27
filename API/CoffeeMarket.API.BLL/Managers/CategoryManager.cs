using CoffeeMarket.API.BLL.DTO.Response;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Managers
{
	public class CategoryManager : ICategoryManager
	{
		private readonly ICategoryService _categoryService;

		public CategoryManager(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public async Task<List<ProductCategoryResponse>> GetAll()
		{
			var response = new List<ProductCategoryResponse>();
			var res = await _categoryService.GetAllAsync();

			foreach (var category in res)
			{
				var newitem = new ProductCategoryResponse(category);
				response.Add(newitem);
			}
			return response;
		}

		public async Task<List<ProductCategoryResponse>> GetByTypeId(string typeid)
		{
			var response = new List<ProductCategoryResponse>();
			var res = await _categoryService.GetByTypeId(typeid);

			foreach (var category in res)
			{
				var newitem = new ProductCategoryResponse(category);
				response.Add(newitem);
			}
			return response;
		}
	}
}
