using CoffeeMarket.API.BLL.Interfaces.Services;
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
	public class OrderService : DbFactoryBase, IOrderService
	{
		public OrderService(IConfiguration configuration) : base(configuration)
		{
		}

		public async Task<Order> CreateAsync(Order entity)
		{
			foreach (var order in entity.PR_ProductID)
			{
				var orderid = new Guid();
				var id = new Guid();
				entity.OR_OrderID = orderid.ToString();
				entity.OR_ID = id;
				var sql = @"INSERT INTO [Order] (OR_ID, OR_OrderID, PR_ProductID,OR_OrderDate,Quantity,Amount,State_Slug) VALUES (@OR_ID,OR_OrderID,PR_ProductID,OR_OrderDate,Quantity, Amount,State_Slug)";
				var isSuccess = await DbExecuteAsync<_Stock>(sql,entity);

				
			}
			return entity;
		}

		public Task<bool> DeleteAsync(object id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ExistAsync(object id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Order>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Order> GetByIdAsync(object id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateAsync(Order entity)
		{
			throw new NotImplementedException();
		}
	}
}
