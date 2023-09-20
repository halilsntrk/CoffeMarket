using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.DAL.Entities;
using CoffeMarket.API.DAL.Contracts;
using CoffeMarket.API.DAL.Data;
using Microsoft.Extensions.Configuration;

namespace CoffeeMarket.API.BLL.Services
{
	public class CoffeService : DbFactoryBase,ICoffeeService
	{
		public CoffeService(IConfiguration configuration) : base(configuration)
		{
		}

		public Task<Coffee> CreateAsync(Coffee entity)
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

		public async Task<IEnumerable<Coffee>> GetAllAsync()
		{

			var sql = "SELECT * FROM Coffee";
			var Coffee = await DbQueryAsync<Coffee>(sql);
			return Coffee;
		}

		public Task<Coffee> GetByIdAsync(object id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateAsync(Coffee entity)
		{
			throw new NotImplementedException();
		}
	}
}
