using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Deneme.Models;

namespace Deneme.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
    {
        
        var ders = new odev
        {
            Ad = "Matematik",
            Seviye = "Orta",
            Ogretmen = "Ahmet Bey"
        };

        
        return View(ders);
    }
}