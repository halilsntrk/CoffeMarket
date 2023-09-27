using CoffeeMarket.API.DAL.Entities;
using CoffeMarket.API.DAL.Contracts;
using CoffeMarket.API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Services
{
	public interface ICategoryService: IRepository<ProductCategory>
	{
		public Task<IEnumerable<ProductCategory>> GetByTypeId(string typeId);
	}
}
