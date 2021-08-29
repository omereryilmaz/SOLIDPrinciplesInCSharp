using System;

namespace ISP
{
  public class Otomobil : IArac
  {
    public void GeriSur()
    {
      Console.WriteLine("Geri Sur");
    }

    public void IleriSur()
    {
      Console.WriteLine("Ileri Sur");
    }

    public void OrtalamaYakitTuketimiHesapla()
    {
      Console.WriteLine("Ortalama Yakit Hesaplama");
    }
  }
}