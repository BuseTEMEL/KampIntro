using System;

namespace Date3_RefOutKeyword
{
    //Ref ve Out Keyword ve ikisi arasındaki farkı anlayalım.
    public class Program
    {
        private static string orijinal_Value;

        //geriye herhangi bir değer dönmeyen bir metod yazalım ve içerisine int tipinde 3 değişken alsın 
        //sonrasında bu değerlerden birini metod içerisinde değiştirsin ve değişkenin metoddan önceki ve sonraki değerlerine bir bakalım 
        static void Main(string[] args)
        {
            // ilk örnek ref ve out kullanmadan parametre göndermek.
            // // Value Type'lar metodlara birebir kopyası oluşturularak geçirilirler ve metod içerisinde o değişkenle ilgili yapılan değişikliklerden orjinal değer etkilenmez.
            Console.WriteLine(" ref ve out kullanmadan parametre göndermek: \n");
            int orijinalValue = 50;
            Console.WriteLine("ChangeMethod'dan önce :" + orijinalValue);  //output 50
            ChangeMethod(1, 2, orijinalValue);
            Console.WriteLine("ChangeMethod'dan sonra :" + orijinalValue); // output 50
            Console.WriteLine("_______________");

            //ikinci örnek ref kullanarak parametre göndermek.
            //Referans yolu ile metoda parametre olarak geçtiğimiz değişken üzerinde yapılacak bütün değişiklikler orjinal değeri etkileyecektir çünkü artık o metod içerisinde değişkenin bir kopyası değilde RAM'de ki adresi bulunmaktadır.
            Console.WriteLine("ref kullanarak parametre göndermek: \n");
            int orijinalValueRef = 50;
            Console.WriteLine("Change_Method'dan önce :" + orijinalValueRef);  //output 50
            Change_Method(1, 2, ref orijinalValueRef);
            Console.WriteLine("Change_Method'dan sonra :" + orijinalValueRef);  //output 53
            Console.WriteLine("_______________");

            //üçüncü örnek out kullanarak paramatre göndermek.
            // out da ref ile aynı ama hizmet verir sadece ref te başlangıç değeri girme zorunluluğu vardır. out ta yoktur.
            // ayrıca ref i metotta i değişkeninde herhangi bir değişiklik yapmadan kullanabilirsiniz ancak out ta değişiklik yapmadan kullanılamaz.
            Console.WriteLine("out kullanarak paramatre göndermek: \n");
            int  orijinalValueOut =50;
            Console.WriteLine("changeMethod'dan önce :" + orijinalValueOut);
            changeMethod(1,2, out orijinalValueOut);
            Console.WriteLine("changeMethod 'dan sonra :" + orijinalValueOut);
            Console.WriteLine("_______________");

            //dördüncü örnekte ref ve out parametrelerini birlikte kullanarak karşılaştıracağımız bir örnek yapalım.
            Console.WriteLine("ref ve out birlikte kullanımı :\n");
            int refValue = 4;
            int outValue=0;

            Console.WriteLine("ChangesMethod ' dan sonra :" + refValue);
            Console.WriteLine("ChangesMethod 'dan sonra :" + outValue);

        }

        static void ChangeMethod(int x, int y, int i)
        {
            i = i + x + y;
        }

        static void Change_Method(int a, int b, ref int J)
        {
            J = a + b + J;
        }

        static void changeMethod(int m, int n, out int k)
        {
            k = 50;
            k = k + m + n; 
        }

        static void ChangesMethod (ref int d , out int e)
        {
            e = 8; // e' ye değer atamak zorunludur. çünkü out parametresi kullandık önünde.
            d = d + 2;  // d için böyle bir zorunluluk yoktur çünkü ref parametresi kullandık.
        }
    }
}

