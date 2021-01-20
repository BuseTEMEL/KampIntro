using System;

namespace WDate2
{    
    //Herhangi bir e-ticaret sistemine giriniz.
    //Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir.Siz de Urun(Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.
    //Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.urunAdi = "Ceket";
            product1.renk = "Gri";
            product1.beden = 40;
            product1.fiyat = 299.90;

            Product product2 = new Product();
            product2.urunAdi = "Pantolon";
            product2.renk = "Siyah";
            product2.beden = 42;
            product2.fiyat = 199.90;

            Product product3 = new Product();
            product3.urunAdi = "Gömlek";
            product3.renk = "Beyaz";
            product3.beden = 40;
            product3.fiyat = 159.99;

            Product[] products = new Product[] { product1, product2, product3 };
            //Product class ımın artık birden çok elemanı var product1, product2, product3.Bunun için dizi haline getirmeliyim bunu.products ise takma adı.
            foreach (var product in products)
            {
                Console.WriteLine("ÜRÜN ADI :" + product.urunAdi + "\n" + "RENK :" + product.renk + "\n" + "BEDEN :" + product.beden + " \n" + "FİYAT :" + product.fiyat + "\n");

            }

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("ÜRÜN ADI :" + products[i].urunAdi + "\n" + "RENK :" + products[i].renk + "\n" + "BEDEN :" + products[i].beden + " \n" + "FİYAT :" + products[i].fiyat + "\n");
            }

            int a = 0;

            while (a < products.Length)
            {
                Console.WriteLine("ÜRÜN ADI :" + products[a].urunAdi + "\n" + "RENK :" + products[a].renk + "\n" + "BEDEN :" + products[a].beden + " \n" + "FİYAT :" + products[a].fiyat + "\n");
                a++;

            }


            Console.ReadLine();

        }
        class Product
        {
            public string urunAdi { get; set; }
            public string renk { get; set; }
            public int beden { get; set; }
            public double fiyat { get; set; }
            // bu sekilde arttirabiliriz.
        }
    }
}
