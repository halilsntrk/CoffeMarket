using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarketPanel.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
