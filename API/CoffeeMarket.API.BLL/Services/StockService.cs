using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.DAL.Entities;
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
	public class StockService : DbFactoryBase, IStockService
	{
		public StockService(IConfiguration configuration) : base(configuration)
		{
		}

		public Task<_Stock> CreateAsync(_Stock entity)
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

		public async Task<IEnumerable<_Stock>> GetAllAsync()
		{
			var sql = "SELECT * FROM Stock";
			var stocks = await DbQueryAsync<_Stock>(sql);
			return stocks;
		}

		public Task<_Stock> GetByIdAsync(object id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateAsync(_Stock entity)
		{
			throw new NotImplementedException();
		}
	}
}
