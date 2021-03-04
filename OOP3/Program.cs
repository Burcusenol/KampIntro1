using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {

        //interfaceler genelde operasyonel işlemlerde kullanılır
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);


            //interfacelerde kendini implement eden classın referanslarını tutabilir

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager,tasıtKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //interfaceleri içerikleri aynı olan ama kodları farklı olan durumlar için kullanıız
            //loglar bir dosyada,veritabanında tutulabilir


        }
    }
}
