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
            Ad = "İngilizce",
            Seviye = "Zor",
            Ogretmen = "Mert"
        };

        
        return View(ders);
    }
}