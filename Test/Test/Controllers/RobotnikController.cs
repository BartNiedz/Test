using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using System.Xml.Linq;
using Test.Models;

namespace Test.Controllers
{
    public class RobotnikController : Controller
    {
        public static List<Robotnik> robotniks;
        public IActionResult Robotnik()
        {
            if (robotniks == null)
            {
                robotniks = new List<Robotnik>();
            }
            return View(robotniks);
        }
        [HttpPost]
        public IActionResult Robotnik(string name, int age)
        {
            Robotnik robotnik = new Robotnik();
            robotnik.name = name;
            robotnik.age = age;
            
            
            if (robotniks ==null) { 
            robotniks = new List<Robotnik>();
            }
            
            robotniks.Add(robotnik);
            
            
            

            return View(robotniks);
        }
        public IActionResult RobotnikRemove(Robotnik robotnik) 
        {
            
            robotniks.Remove(robotnik);

            return RedirectToAction("Robotnik", "Robotnik");
        }
    }
}
