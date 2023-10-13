using Microsoft.AspNetCore.Mvc;

namespace FutureValueCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "James";
            ViewBag.FV = 9999.99;
            return View();
        }
    }
}
