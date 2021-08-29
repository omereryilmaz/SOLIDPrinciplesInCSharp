namespace SRP
{
  public class Kare : Sekil
  {
    private double _kenarUzunlugu;

    public Kare(double kenarUzunlugu)
    {
      _kenarUzunlugu = kenarUzunlugu;
    }

    public override double Cevre()
    {
      return _kenarUzunlugu * 4;
    }
  }
}