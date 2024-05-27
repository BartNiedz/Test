using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Test.Models;

namespace Test.Controllers
{
    public class RobotnikController : Controller
    {
        public static List<Robotnik> robotniks;
        public IActionResult Robotnik()
        {
            return View();
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
    }
}
