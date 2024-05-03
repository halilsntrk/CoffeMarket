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
    public class UserService : DbFactoryBase, IUserService
    {
        public UserService(IConfiguration configuration) : base(configuration)
        {
        }

        public Task<User> CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
