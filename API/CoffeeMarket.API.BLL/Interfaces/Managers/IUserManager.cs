using CoffeeMarket.API.BLL.DTO.Request.User;
using CoffeeMarket.API.BLL.DTO.Response.StockRes;
using CoffeeMarket.API.BLL.DTO.Response.UserRes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Managers
{
    public interface IUserManager
    {
        public Task<string> Create();
        public Task<UserLoginResponse> Login(UserLoginRequest req);
    }
}
