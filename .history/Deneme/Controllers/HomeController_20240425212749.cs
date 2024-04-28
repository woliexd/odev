using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Deneme.Models;

namespace Deneme.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index()
    {
        // Ders nesnesi oluştur
        var ders = new Ders
        {
            Ad = "Matematik",
            Seviye = "Orta",
            Ogretmen = "Ahmet Bey"
        };

        // Ders nesnesini view'e gönder
        return View(ders);
    }
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
