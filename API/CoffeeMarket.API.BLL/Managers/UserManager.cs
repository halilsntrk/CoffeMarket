using CoffeeMarket.API.BLL.DTO.Request.User;
using CoffeeMarket.API.BLL.DTO.Response.UserRes;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Managers
{
    public  class UserManager : IUserManager
    {
        private IUserService _userService;

        public UserManager(IUserService userService)
        {
            _userService = userService;
        }

        public Task<string> Create()
        {
            throw new NotImplementedException();
        }

        public async Task<UserLoginResponse> Login(UserLoginRequest req)
        {
           var res =  _userService.GetAllAsync().Result.FirstOrDefault(x=> x.USR_Username == req.username && x.USR_Password == req.password);
            if (res != null)
            {
                var user = new UserLoginResponse()
                {
                    username = res.USR_Username,
                    token = res.USR_Token,
                    validation = res.USR_Validation,
                };
                return user;
            }

            return new UserLoginResponse();
        }
    }
}
