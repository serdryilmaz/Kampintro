using System;

namespace MyGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenerics<string> isimler = new MyGenerics<string>();
            isimler.Add("Serdar");
        }
    }
}
