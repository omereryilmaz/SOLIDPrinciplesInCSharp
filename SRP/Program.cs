using System.Collections.Generic;

namespace SRP // Single Responsible Prinsiple
{
  class Program
  {
    static void Main(string[] args)
    {
      double toplamCevre = 0;
      List<Kare> kareList = new List<Kare>()
      {
          new Kare(2),
          new Kare(3)
      };

      CevreHesapla cevreHesapla = new CevreHesapla(kareList);
      toplamCevre = cevreHesapla.ToplamCevreUzunlugu();

      CevreYazdir cevreYazdir = new CevreYazdir(toplamCevre);
      cevreYazdir.EkranaYaz();
    }
  }
}
