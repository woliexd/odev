using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Deneme.Models;

namespace Deneme.Controllers;

public class DersController : Controller
{
    public IActionResult Index()
    {
        // Ders nesnesi oluştur
        var ders = new Ders
        {
            KitapAdi = "Yüzüklerin Efendisi",
            YazarAdi = "J.R.R. Tolkien",
            YayinlanmaTarihi = new DateTime(1954, 7, 29),
            Turu = "Fantastik",
            SayfaSayisi = 1178,
            Fiyat = 39.99m
        };

        // Ders nesnesini view'e gönder
        return View(ders);
    }
}