using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.DAL.Entities;
using CoffeMarket.API.DAL.Contracts;
using CoffeMarket.API.DAL.Data;
using CoffeMarket.API.DAL.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Services
{
	public class CategoryService : DbFactoryBase,ICategoryService
	{
        public CategoryService(IConfiguration configuration) : base(configuration)
        {
            
        }

        public Task<ProductCategory> CreateAsync(ProductCategory entity)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteAsync(object id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ExistAsync(object id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<ProductCategory>> GetAllAsync()
		{
			var sql = "SELECT * FROM ProductCategory";
			var categories= await DbQueryAsync<ProductCategory>(sql);
			return categories;
		}

		public Task<ProductCategory> GetByIdAsync(object id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<ProductCategory>> GetByTypeId(string typeId)
		{
			var sql = "SELECT * FROM ProductCategory WHERE TypeID = @TypeID ";
			var category = await DbQueryAsync<ProductCategory>(sql, new { TypeID = typeId });
			return category;
		}

		public Task<bool> UpdateAsync(ProductCategory entity)
		{
			throw new NotImplementedException();
		}
	}
}
