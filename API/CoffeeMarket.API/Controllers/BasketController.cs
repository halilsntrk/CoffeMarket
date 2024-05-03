using CoffeeMarket.API.BLL.Interfaces.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
    [Authorize]
    [Route("/[controller]")]
    [ApiController]
    public class BasketController : Controller
    {
        private readonly IBasketManager _basketManager;

        public BasketController(IBasketManager basketManager)
        {
            _basketManager = basketManager;
        }

        //Sepetin ilk oluşumu
        public bool Create(string token)
        {
            //token çözümleme
            _basketManager.CreateBasket(token);
            return true;
        }
        //Sepete ürün ekleme
        public IActionResult Add([FromBody] ProductToBasket product)
        {

            return View();
        }
        //Sepetten ürün çıkarma
        public IActionResult Delete()
        {
            return View();
        }



    }
}
