using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class EsnafKredisiManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void Uygula()
        {
            Console.WriteLine("Esnaf kredisi ihesaplandı");        }
    }
}
