using DIP.Abstract;

namespace DIP
{
  public class Kare : Sekil
  {
    KareCizdir kareCizdir = new KareCizdir();
    public override void SekilCiz()
    {
      kareCizdir.SekilCiz();
    }
  }
}