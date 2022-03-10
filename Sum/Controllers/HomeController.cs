using Microsoft.AspNetCore.Mvc;
using Sum.Models;
using System.Diagnostics;

namespace Sum.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Sum(int[] arr)
        {
            var sum = arr.Sum();
            return Json(sum);
        }
    }
}