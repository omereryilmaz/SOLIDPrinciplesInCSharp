namespace LSP
{
  public class Kare : Sekil
  {
    private double _kenar;
    public Kare(double kenar)
    {
      _kenar = kenar;
    }

    public override double AlanHesapla()
    {
      return _kenar * _kenar;
    }
  }
}