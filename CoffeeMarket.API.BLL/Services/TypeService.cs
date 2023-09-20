﻿using CoffeeMarket.API.BLL.Interfaces.Services;
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
	public class TypeService : DbFactoryBase,ITypeService
	{
		public TypeService(IConfiguration configuration) : base(configuration)
		{

		}

		public Task<CoffeeType> CreateAsync(CoffeeType entity)
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

		public Task<IEnumerable<CoffeeType>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<CoffeeType> GetByIdAsync(object id)
		{
			var sql = "SELECT * FROM CoffeeType WHERE TypeID = @TypeId";
			var type = await DbQuerySingleAsync<CoffeeType>(sql, new { TypeID = id });
			return type;
		}

		public Task<bool> UpdateAsync(CoffeeType entity)
		{
			throw new NotImplementedException();
		}
	}
}
