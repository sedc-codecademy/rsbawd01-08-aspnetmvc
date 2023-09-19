using Microsoft.AspNetCore.Mvc;
using OurFirstWebApp.Models;
using System.Diagnostics;

namespace OurFirstWebApp.Controllers
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
            string helloWorld = "Hello from SEAVUS EDUCATION CENTER ACADEMY";

            List<string> students = new List<string>
            {
                "Biljana", "Vitomir", "Marko", "Miroslav", "Milan", "Attila"
            };

            // 
            ViewData["Students"] = students;

            return View();
        }

        public string OurAction()
        {
            string helloWorld = "Hello World this our action which returns the data!";

            return helloWorld;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}