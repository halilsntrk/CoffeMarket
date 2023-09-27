using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMarket.API.DAL.Contracts
{
	public interface IRepository<T>
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(object id);
		Task<T> CreateAsync(T entity);
		Task<bool> UpdateAsync(T entity);
		Task<bool> DeleteAsync(object id);
		Task<bool> ExistAsync(object id);
	}
}
