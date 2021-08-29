namespace OCP
{
  public class Daire : Sekil
  {
    public double YariCap { get; set; }

    public override double AlanHesapla()
    {
      return 3.14 * YariCap * YariCap;
    }
  }
}