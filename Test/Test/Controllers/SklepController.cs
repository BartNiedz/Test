using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Test.Models;

namespace Test.Controllers
{
    public class SklepController : Controller
    {
        public static List<Sklep> shop;
        public static List<Sklep> koszyk;
        public IActionResult Sklep()
        {
            if (shop == null)
            {
                shop = new List<Sklep>();
            }
            return View(shop);
        }
        [HttpPost]
        public IActionResult Sklep(string name,double price)
        {
            Sklep produkt = new Sklep();
            produkt.Id= Guid.NewGuid();
            produkt.Nazwa = name;
            produkt.Cena = price;
            produkt.Stan = 1;
            
            if (shop == null)
            {
                shop = new List<Sklep>();
            }
            
            shop.Add(produkt);

            return View(shop);
        }
        public IActionResult ProductEdit(Guid Id)
        {
            Sklep produkt = shop.FirstOrDefault(x => x.Id == Id);
            
            return View(produkt);
        }
        [HttpPost]
        public IActionResult ProductSent(Sklep model)
        {
            Sklep produkt = shop.FirstOrDefault(x => x.Id == model.Id);
            shop.Remove(produkt);
            shop.Add(model);
            return RedirectToAction("Sklep", "Sklep");
        }
        public IActionResult ProductDelete(Guid Id)
        {
            Sklep produkt = shop.FirstOrDefault(x=>x.Id==Id);
            shop.Remove(produkt);

            return RedirectToAction("Sklep", "Sklep");
        }     

        //do edycji
        public IActionResult CartList(Sklep model)
        {


            Sklep produkt = new Sklep() ;
            
            produkt.Id = model.Id;
            produkt.Nazwa = model.Nazwa;
            produkt.Cena = model.Cena;
            produkt.Stan = model.Stan;

            if (koszyk == null)
            {
                koszyk = new List<Sklep>();
            }

            koszyk.Add(produkt);
            return View(koszyk);
        }
    }
}
