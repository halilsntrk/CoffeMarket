using CoffeeMarket.API.BLL.DTO.Request.User;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserManager _userManager;
        private IBasketManager _basketManager;

        public UserController(IUserManager userManager, IBasketManager basketManager)
        {
            _userManager = userManager;
            _basketManager = basketManager;
        }

        public async Task<string> Create(UserCreateRequest req)
        {
            return await _userManager.Create();
        }

        public string Login(UserLoginRequest req)
        {
            //kullanıcı login olduğun sepet oluşur. Yada sepeti varsa o gelir
            _basketManager.CreateBasket("");
            _userManager.Login();
            return "";
        }
    }
}
