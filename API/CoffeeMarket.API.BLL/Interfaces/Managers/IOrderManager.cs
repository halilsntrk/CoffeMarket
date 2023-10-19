using CoffeeMarket.API.BLL.DTO.Request.Order;
using CoffeeMarket.API.BLL.DTO.Response.StockRes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Managers
{
	public interface IOrderManager
	{
		public Task<string> Create(OrderRequest request);
	}
}
