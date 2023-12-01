using CoffeeMarketPanel.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarketPanel.Controllers
{
    
    public class UserController : Controller
    {

        private readonly ILogger<UserController> _logger;
       

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public ActionResult Login(UserLoginRequest user)
        {

            _logger.Log(LogLevel.Warning, $"{user.username} giriþ yaptý");

            return RedirectToAction("index","dashboard",user);
        }
    }

 
}
