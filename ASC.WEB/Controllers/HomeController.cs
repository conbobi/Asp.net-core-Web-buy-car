using ASC.WEB.Configuration;
using ASC.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ASC.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IOptions<ApplicationSettings> _settings;

        public HomeController(ILogger<HomeController> logger, IOptions<ApplicationSettings> settings)
        {
            _logger = logger;
            _settings = settings;
        }

        public IActionResult Index()
        {   
            ViewBag.Title = _settings.Value.ApplicationTitle; 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
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
