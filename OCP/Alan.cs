namespace OCP
{
  public class Alan
  {
    private Sekil _sekil;
    public Alan(Sekil sekil)
    {
      _sekil = sekil;
    }

    public double Hesapla()
    {
      return _sekil.AlanHesapla();
    }
  }
}