using AutoWrapper.Wrappers;
using CoffeeMarketPanel.Business.Abstract.User;
using CoffeeMarketPanel.Helpers;
using CoffeeMarketPanel.Models.Request;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Treblle.Net.Core;

namespace CoffeeMarketPanel.Controllers
{

    public class UserController(ILogger<UserController> _logger, IUserService _userService) : Controller
    {

        [HttpPost("/create")]
        public async Task<ApiResponse> CreateUser([FromBody] UserLoginRequest user)
        {
            var response = await _userService.Create(user);
            return new ApiResponse { Result = response.data, Message = response.message, StatusCode = 200 };

        }

        [Treblle]

        [HttpPost("/login")]
        public async Task<ApiResponse> Login([FromBody] UserLoginRequest user)
        {
           var response =  await _userService.Login(user);
            return new ApiResponse { Result = response.data,Message = response.message ,StatusCode = 200};

        }
   
    }

}



