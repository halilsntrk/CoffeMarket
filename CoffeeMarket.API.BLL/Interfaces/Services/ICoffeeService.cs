using CoffeeMarket.API.DAL.Entities;
using CoffeMarket.API.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Services
{
	public interface ICoffeeService : IRepository<Coffee>
	{
	}
}
