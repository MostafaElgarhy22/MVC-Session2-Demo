using Microsoft.AspNetCore.Mvc;

namespace Project_Structure.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] //  GET: /Home/Index
        public IActionResult Index()
        {
            return View();
        }public IActionResult AbouUs()

        {
            return View();
        }public IActionResult Privacy()

        {
            return View();
        }public IActionResult ContactUs()

        {
            return View();
        }
    }
}
