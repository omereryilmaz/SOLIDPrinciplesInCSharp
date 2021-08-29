using System;

namespace ISP // Interface Segregation Principle
{
  public class Otomobil : IArac, IYakit
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