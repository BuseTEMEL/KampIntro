using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerServices)  
        {                                           //method injection
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        //KonutKrediManager konutKrediManager = new KonutKrediManager();
        //konutKrediManager.Hesapla();  // dersem tüm başvurular konut kredisine bağlı çalışır. }
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
