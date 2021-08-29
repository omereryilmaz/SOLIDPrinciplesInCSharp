using System;

namespace ISP // Interface Segregation Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil();
            oto.IleriSur();
            oto.GeriSur();
            oto.OrtalamaYakitTuketimiHesapla();
        }
    }
}
