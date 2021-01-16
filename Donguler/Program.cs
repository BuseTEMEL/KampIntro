using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştrme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            //array - dizi kullan.. (DİNAMİK OLSUN !!)

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştrme Kampı" , "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python" };

            for (int i = 0; i < kurslar.Length; i++) //kurslarda ne kadar eleman varsa 0 dan başla ve ne kadar varsa yazdır. (DİNAMİK OLSUN!!)
            {                                        // ekleme çıkarma yaparken diziye buraya dokunmuyorum bile. -DİNAMİKLEŞTİRDİM.
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar) //foreach dizi temelli yapıları tek tek dönmeye yarıyor.
            {
                Console.WriteLine(kurs);  //if else de i inci elemanları yazdırıyorduk ama foreach de daha kolay. her bir elemanı tek tek döner zaten.
            }

            Console.WriteLine("Sayfa Sonu - footer");
            Console.ReadLine();
        }
    }
}
