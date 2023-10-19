using CoffeeMarket.API.BLL.DTO.Request.Order;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeMarket.API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace CoffeeMarket.API.BLL.Managers
{
	public class OrderManager : IOrderManager
	{
		private IOrderService _orderService;

		public OrderManager(IOrderService orderService)
		{
			_orderService = orderService;
		}

		public async Task<string> Create(OrderRequest request)
		{
			var req = new Order
			{
				Amount = request.amount,
				OR_OrderDate = DateTime.Now,
				PR_ProductID = request.productid,
				Quantity = request.quantity,
				State_Slug = "CURRENT",
			};
			var res = await _orderService.CreateAsync(req);
			return res.OR_OrderID;
		}
	}
}
