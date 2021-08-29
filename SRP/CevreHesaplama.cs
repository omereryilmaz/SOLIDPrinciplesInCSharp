using System;
using System.Collections.Generic;

namespace SRP
{
  public class CevreHesapla
  {
    private IEnumerable<Sekil> _sekiller;
    private double _toplamCevre;

    public CevreHesapla(IEnumerable<Sekil> sekiller)
    {
      _sekiller = sekiller;
    }

    public double ToplamCevreUzunlugu()
    {
      _toplamCevre = 0;
      foreach (var sekil in _sekiller)
      {
        _toplamCevre += sekil.Cevre();
      }

      return _toplamCevre;
    }

    public void EkranaYazdir()
    {
      Console.WriteLine("Sekillerin Toplam Cevresi: " + _toplamCevre);
    }
  }
}