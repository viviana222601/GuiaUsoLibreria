using GuiaUsoLibreria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GuiaUsoLibreria.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Archivos()
        {
            return View();
        }
        public IActionResult Criptografia()
        {
            return View();
        }
        public IActionResult EntradaDatos()
        {
            return View();
        }
        public IActionResult Middleware()
        {
            return View();
        }
        public IActionResult Versionamiento()
        {
            return View();
        }
    }
}
