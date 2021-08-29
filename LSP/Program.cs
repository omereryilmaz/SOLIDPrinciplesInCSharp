using System;

namespace LSP // Liskov Substitution Principle
{
  class Program
  {
    static void Main(string[] args)
    {
      Kare kare = new Kare(5);
      Console.WriteLine(kare.AlanHesapla());
    }
  }
}
