using System.Collections.Generic;

namespace SRP
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Kare> kareList = new List<Kare>()
      {
          new Kare(2),
          new Kare(3)
      };

      CevreHesapla cevreHesapla = new CevreHesapla(kareList);
      cevreHesapla.ToplamCevreUzunlugu();
      cevreHesapla.EkranaYazdir();
    }
  }
}
