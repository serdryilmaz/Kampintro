using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
          
            Console.WriteLine("Müşteri " + musteri.Name + " eklendi");
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri " + musteri.Name + " silsindi");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri " + musteri.Name + " güncellendi");
        }
    }
}
