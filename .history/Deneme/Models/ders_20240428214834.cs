using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme.Models
{
 public class Ders
{
    public string KitapAdi { get; set; }
    public string YazarAdi { get; set; }
    public DateTime YayinlanmaTarihi { get; set; }
    public string Turu { get; set; }
    public int SayfaSayisi { get; set; }
    public decimal Fiyat { get; set; }
}
}