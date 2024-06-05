using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class SklepController : Controller
    {
        public static List<Sklep> shop;
        public IActionResult Sklep()
        {
            if (shop == null)
            {
                shop = new List<Sklep>();
            }
            return View(shop);
        }
        [HttpPost]
        public IActionResult Sklep(string name,string price)
        {
            Sklep produkt = new Sklep();
            produkt.Id= Guid.NewGuid();
            produkt.Nazwa = name;
            produkt.Cena = price;
            produkt.Stan = 1;
            int ilosc = produkt.Stan + 1;
            if (shop == null)
            {
                shop = new List<Sklep>();
            }
            
            shop.Add(produkt);

            return View(shop);
        }
        public IActionResult StockAdd()
        {
            return View();
        }
    }
}
