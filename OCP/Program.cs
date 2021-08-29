using System;

namespace OCP // Open - Closed Principle
{
  class Program
  {
    static void Main(string[] args)
    {
      Dikdortgen d = new Dikdortgen();
      d.KenarA = 4;
      d.KenarB = 5;
      Alan alan = new Alan(d);
      Console.WriteLine(alan.Hesapla());
    }
  }
}
