using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.DAL.Entities;
using CoffeMarket.API.DAL.Contracts;
using CoffeMarket.API.DAL.Data;
using Microsoft.Extensions.Configuration;

namespace CoffeeMarket.API.BLL.Services
{
	public class ProductService : DbFactoryBase,IProductService
	{
		public ProductService(IConfiguration configuration) : base(configuration)
		{
		}

		public async Task<Product> CreateAsync(Product entity)
		{
			entity.PR_ID = Guid.NewGuid();
			var sql = @"INSERT INTO Product (PR_ID,PR_ProductID ,PR_TypeID, PR_Name, PR_Price, PR_ListImage, PR_DetailImage, PR_SpotDetail)
                    VALUES (@PR_ID,@PR_ProductID,@PR_TypeID, @PR_Name, @PR_Price, @PR_ListImage, @PR_DetailImage, @PR_SpotDetail)";

			await DbQuerySingleAsync<string>(sql, entity);

			return entity;
		}

		public Task<bool> DeleteAsync(object id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ExistAsync(object id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Product>> GetAllAsync()
		{

			var sql = "SELECT * FROM Product";
			var products = await DbQueryAsync<Product>(sql);
			return products;
		}

		public async Task<Product> GetByIdAsync(object id)
		{
			var sql = "SELECT * FROM Product WHERE PR_ID = @PR_ID ";
			var product = await DbQuerySingleAsync<Product>(sql,new {PR_ID = id});
			return product;
		}

		public async Task<IEnumerable<Product>> GetByTypeId(string typeId)
		{
			var sql = "SELECT * FROM Product WHERE PR_TypeID = @PR_TypeID ";
			var product = await DbQueryAsync<Product>(sql, new { PR_TypeID = typeId });
			return product;
		}

		public Task<bool> UpdateAsync(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}
