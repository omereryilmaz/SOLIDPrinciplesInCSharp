namespace OCP
{
  public class Alan
  {
    private Dikdortgen _dikdortgen;
    public Alan(Dikdortgen dikdortgen)
    {
      _dikdortgen = dikdortgen;
    }

    public double Hesapla()
    {
      return _dikdortgen.KenarA * _dikdortgen.KenarB;
    }
  }
}