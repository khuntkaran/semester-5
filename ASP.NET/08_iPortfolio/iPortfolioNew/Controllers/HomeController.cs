using iPortfolioNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace iPortfolioNew.Controllers
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
            ViewBag.Title = "Index";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

        public IActionResult Resume()
        {
            ViewBag.Title = "Resume";
            return View();
        }

        public IActionResult Portfolio()
        {
            ViewBag.Title = "Portfolio";
            return View();
        }

        public IActionResult Services()
        {
            ViewBag.Title = "Services";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}