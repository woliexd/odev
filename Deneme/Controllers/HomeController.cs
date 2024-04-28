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
            KitapAdi = "Yüzüklerin Efendisi",
            YazarAdi = "J.R.R. Tolkien",
            YayinlanmaTarihi = new DateTime(1954, 7, 29),
            Turu = "Fantastik",
            SayfaSayisi = 1178,
            Fiyat = 39.99m
        };

        
        return View(ders);
    }
}