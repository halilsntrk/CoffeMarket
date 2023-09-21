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

		public Task<Product> CreateAsync(Product entity)
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

		public async Task<IEnumerable<Product>> GetAllAsync()
		{

			var sql = "SELECT * FROM Product";
			var coffees = await DbQueryAsync<Product>(sql);
			return coffees;
		}

		public async Task<Product> GetByIdAsync(object id)
		{
			var sql = "SELECT * FROM Product WHERE PR_ID = @PR_ID ";
			var coffee = await DbQuerySingleAsync<Product>(sql,new {PR_ID = id});
			return coffee;
		}

		public Task<bool> UpdateAsync(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}
