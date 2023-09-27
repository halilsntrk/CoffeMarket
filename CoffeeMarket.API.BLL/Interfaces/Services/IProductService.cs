using CoffeeMarket.API.DAL.Entities;
using CoffeMarket.API.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Services
{
	public interface IProductService : IRepository<Product>
	{
		public Task<IEnumerable<Product>> GetByTypeId(string typeId);
	}
}
