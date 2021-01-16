using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("---------------Metotlar-------------");

            //instance - örnek
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);   //metot böyle çağırılır.
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetmanager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

            
        }
    }
}

//Dont repeat yourself - DRY
//Clean Code - Temiz kod yazma
//Best Practice - teknikler ipuçları 