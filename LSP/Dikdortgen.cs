namespace LSP
{
  public class Dikdortgen : Sekil
  {
    private double KenarA;
    private double KenarB;

    public Dikdortgen(double kenarA, double kenarB)
    {
      this.KenarA = kenarA;
      this.KenarB = kenarB;
    }

    public override double AlanHesapla()
    {
      return KenarA * KenarB;
    }
  }
}