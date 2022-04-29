using Microsoft.AspNetCore.Mvc;
using Store.Models;
using System.Diagnostics;
using RockLib.Logging;
using ILogger = RockLib.Logging.ILogger;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(ILogger logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.Debug("Starting home page");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.Debug("Opened Privacy page");
            return View();
        }

        public IActionResult Clients()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}