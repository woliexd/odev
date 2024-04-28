using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Deneme.Models;

namespace Deneme.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
    {
        // Ders nesnesi oluştur
        var ders = new odev
        {
            Ad = "Matematik",
            Seviye = "Orta",
            Ogretmen = "Ahmet Bey"
        };

        // Ders nesnesini view'e gönder
        return View(ders);
    }
}