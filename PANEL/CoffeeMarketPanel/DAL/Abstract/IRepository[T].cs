using CoffeeMarketPanel.DAL.Entities;

namespace CoffeeMarketPanel.DAL.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<IQueryable<T>> Table();
    }
}
