using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarketPanel.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
