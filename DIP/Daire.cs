using DIP.Abstract;

namespace DIP
{
  public class Daire : Sekil
  {
    DaireCizdir daireCizdir = new DaireCizdir();
    public override void SekilCiz()
    {
      daireCizdir.SekilCiz();
    }
  }
}