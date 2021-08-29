using System;

namespace OCP // Open - Closed Principle
{
  class Program
  {
    static void Main(string[] args)
    {
      Dikdortgen dikdortgen = new Dikdortgen();
      dikdortgen.KenarA = 4;
      dikdortgen.KenarB = 5;
      Alan dikdortgenAlan = new Alan(dikdortgen);
      Console.WriteLine("Dikdortgen alani: " + dikdortgenAlan.Hesapla());

      Daire daire = new Daire();
      daire.YariCap = 5;
      Alan daireALan = new Alan(daire);
      Console.WriteLine("Daire alani: " + daireALan.Hesapla());
    }
  }
}
