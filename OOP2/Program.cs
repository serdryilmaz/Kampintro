using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri1.Adi = "Serdar";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Id = 1;
            musteri1.TcNo = "213212121";
            musteri1.MusteriNo = "11111";
            musteri2.SirketAdi = "!";
            musteri2.VergiNo = "";
            musteri2.Id = 2;
            musteri2.MusteriNo = "22222";

        }
    }
}
