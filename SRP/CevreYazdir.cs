using System;

namespace SRP
{
  public class CevreYazdir
  {
    private double _cevreUzunlugu;

    public CevreYazdir(double cevreUzunlugu)
    {
      _cevreUzunlugu = cevreUzunlugu;
    }

    public void EkranaYaz()
    {
      Console.WriteLine("Sekillerin Toplam Cevresi: " + _cevreUzunlugu);
    }

    public void KagidaYaz()
    {
      // Printer kutuphaneleri kullanilabilir
    }
  }

}