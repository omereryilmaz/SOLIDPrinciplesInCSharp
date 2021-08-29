namespace OCP
{
  public class Dikdortgen : Sekil
  {
    public double KenarA { get; set; }
    public double KenarB { get; set; }

    public override double AlanHesapla()
    {
      return KenarA * KenarB;
    }
  }
}