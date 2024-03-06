using MarchSixApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarchSixApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            ViewBag.Persons = new List<string>() { 
            "AMAN",
            "GANESH",
            "VIDYA",
            "VAISHNAVI",
             "RUTUJA",
             "SOURABH"};
            return View();
        }
        public ViewResult Demo() {

            return View();}
        public IActionResult Privacy()
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
