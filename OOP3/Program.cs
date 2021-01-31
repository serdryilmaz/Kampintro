using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            ILoggerService databaseLoggerService = new DarebaseLoggerService();
            ILoggerService fileLoggerSErvice = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendmesiYap(krediler);
        }
    }
}
