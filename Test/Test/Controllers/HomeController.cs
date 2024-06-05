using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using Test.Models;

namespace Test.Controllers
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

        public IActionResult Trojkat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Trojkat(double a, double b, double c)
        {
            Trojkat model = new Trojkat();
            model.a = a;
            model.b = b;
            model.c = c;

            WynikTrojkat result = new WynikTrojkat();

            result.pp = model.PP();
            result.obw = model.Obw();

          //  return View(result);
            return RedirectToAction("TrojkatSent", "Home", new { pp= model.PP(), o= model.Obw() });
        }
        public IActionResult TrojkatSent(double pp, double o)
        {
            WynikTrojkat result = new WynikTrojkat();

            result.pp = pp;
            result.obw = o;

            return View(result);
        }
        public IActionResult Szesciokat()
        {
            Szesciokat z = new Szesciokat();
            z.a = 5;
            z.b = 5;
            z.c = 5;
            double PPSzesciokat = z.PPSzesciokat();
            double OBWSzesciokat = z.ObwSzesciokat();

            return View();
        }
        public IActionResult Szescian()
        {
            Szescian model = new Szescian();
            model.a = 2;
            model.b = 3;
            model.c = 4;

            double result = model.Obj();
        
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
    }
}
