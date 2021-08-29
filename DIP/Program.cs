using System;
using DIP.Abstract;

namespace DIP // Dependency Inversion Principle
{
  class Program
  {
    static void Main(string[] args)
    {
      Sekil daire = new Sekil(new DaireCizdir());
      daire.SekilCiz();

      Sekil kare = new Sekil(new KareCizdir());
      kare.SekilCiz();
    }
  }
}
