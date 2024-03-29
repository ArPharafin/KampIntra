﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {

        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices )
        {
            //Basvuran bilgileri
            //Kredi notu
            //
            krediManager.Hesapla();
            foreach(var loggerService in loggerServices)
            {
                loggerService.Log();

            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
