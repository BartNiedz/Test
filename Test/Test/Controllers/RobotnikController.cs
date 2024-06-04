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
        public IActionResult RobotnikRemove(Guid robotnikId) 
        {
           Robotnik robotnik = robotniks.FirstOrDefault(x => x.robotnikId == robotnikId);                 
            robotniks.Remove(robotnik);

            return RedirectToAction("Robotnik", "Robotnik");
        }
        
        public IActionResult RobotnikEdit(Guid robotnikId)
        {
            Robotnik robotnik = robotniks.FirstOrDefault(x => x.robotnikId == robotnikId);

           // ViewBag.robotnikId = robotnikId;

                                  

            return View(robotnik);
        }
        //[HttpPost]
        public IActionResult RobotnikSent(Robotnik model)
        {
            //var robotnikId = model.robotnikId;
            //var name = model.name;
            //var age = model.age;
            Robotnik robotnik = robotniks.FirstOrDefault(x => x.robotnikId == robotnikId);
            robotniks.Remove(robotnik);
            robotniks.Add(model);

            return RedirectToAction("Robotnik", "Robotnik" /*new { model = model}*/);
        }    
    }
}
