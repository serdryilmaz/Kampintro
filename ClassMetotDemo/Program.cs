using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 123;
            musteri1.Name = "Serdar";
            musteri1.Surname = "Yılmaz";
            Musteri musteri2 = new Musteri();
            musteri2.ID = 124;
            musteri2.Name = "Serkan";
            musteri2.Surname = "Yılmaz";
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Remove(musteri1);
            musteriManager.Update(musteri2);
        }
        
        
    }
}
