using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention - isimlenditme kuralı
        public void Ekle(Urun urun)  //parametre  // Encapsulation
        {
            Console.WriteLine("Sepete Eklendi! :" + urun.Adi );
        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int StokAdedi)  // böyle yazabilirdim ama yukarıdaki gibi yaparsam Encapsulation olur. Daha güvenli.
        {
            Console.WriteLine("Sepete Eklendi! :" +urunAdi);
        }
    }
}
