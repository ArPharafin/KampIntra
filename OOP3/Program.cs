﻿
using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
           // ILoggerService fileLoggerService= new FileLoggerService();
            //ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggers= new List<ILoggerService> { new SmsLoggerService() ,new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);
                
            //basvuruManager.BasvuruYap(konutKrediManager, new List<smsLoggerService> { });

            

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager ,konutKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        
        }
    }
}
