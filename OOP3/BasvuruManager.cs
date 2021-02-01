using System;
using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Basvuran bilgilerini degerlendirme
            //
           
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
