using CoffeeMarket.API.BLL.DTO.Response;
using CoffeeMarket.API.BLL.DTO.Response.StockRes;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Managers
{
	public class StockManager : IStockManager
	{
		private IStockService _stockService;

		public StockManager(IStockService stockService)
		{
			_stockService = stockService;
		}

		public async Task<List<StockResponse>> GetAll()
		{
			var response = new List<StockResponse>();
			var res = await _stockService.GetAllAsync();

			foreach (var stock in res)
			{
				var newitem = new StockResponse(stock);
				response.Add(newitem);
			}
			return response;
		}
	}
}
