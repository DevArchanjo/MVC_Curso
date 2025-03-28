using Microsoft.AspNetCore.Mvc;
using SalesWebMvc_1.Models;
using System.Diagnostics;

namespace SalesWebMvc_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Salles Web MVC App from C# Course";
            ViewData["Professor"] = "Nellio Alves";

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Política de privacidade";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
