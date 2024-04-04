using CoffeeMarketPanel.DAL.Abstract;
using CoffeeMarketPanel.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMarketPanel.DAL.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly CoffeeMarketDbContext _dbContext;


        public Repository(CoffeeMarketDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<T> GetById(Guid id)
        {
            var response =await  _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(t=> t.ID == id);

                return response;
            
        }

        public async Task<List<T>> GetAll()
        {

            var data = await _dbContext.Set<T>().AsNoTracking().ToListAsync();

            // Null değer kontrolü ekle
            if (data != null)
            {
                // Diğer işlemler...
                return data;
            }
            else
            {
                // Gerekirse null ile başa çıkma stratejisini belirle
                return new List<T>();
            }
        }

        public async Task<bool> Create(T entity)
        {
            var data = await _dbContext.Set<T>().AddAsync(entity);
            var res =  _dbContext.SaveChanges();
            return true;
        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                _dbContext.Set<T>().Update(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IQueryable<T>> Table()
        {
            return _dbContext.Set<T>().AsQueryable();
        }
    }
}
