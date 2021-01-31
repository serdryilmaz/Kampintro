using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "serdar";
            kurs1.IzlemeOranı = "68";
            kurs1.KusAdi = "pyton";
            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Sedat";
            kurs2.IzlemeOranı = "35";
            kurs2.KusAdi = "C#";
            Console.WriteLine(kurs1.KusAdi + " " + kurs1.Egitmen);
            
                Console.WriteLine("-------------------------");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
           
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs1.KusAdi + ":"+kurs1.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KusAdi { get; set; }
        public string Egitmen { get; set; }
        public string IzlemeOranı { get; set; }
    }
}
