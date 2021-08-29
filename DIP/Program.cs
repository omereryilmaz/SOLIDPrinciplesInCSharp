using System;

namespace DIP // Dependency Inversion Principle
{
  class Program
  {
    static void Main(string[] args)
    {
      Daire daire = new Daire();
      daire.SekilCiz();

      Kare kare = new Kare();
      kare.SekilCiz();
    }
  }
}
