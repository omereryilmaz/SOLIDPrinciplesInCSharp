namespace DIP.Abstract
{
  public class Sekil
  {
    private ISekilCizdir _sekilCizdir;
    // Injected ISekilCizdir
    public Sekil(ISekilCizdir sekilCizdir)
    {
      _sekilCizdir = sekilCizdir;
    }

    public void SekilCiz()
    {
      _sekilCizdir.SekilCiz();
    }
  }
}