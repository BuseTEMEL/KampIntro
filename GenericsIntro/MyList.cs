using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T tip yerine verdim.
    {
        T[] items;  //metod içine değil class içerisine yazdım diğer metotlar da erişebilsin diye.
        public MyList()  //constructor: class new lendiğinde otomatik çalışan yapı.
        {
            items = new T[0];   //arrayi kullanabilmek için new lememmiz gerekir. çünkü referans tiptir.
           
        }
        public void Add (T item)  // T[] items dan eleman isteniyor. 0 elemanlı şuan bir şey ekleyemem.
        {
            T[] tempArray = items;  //geçici array olan tempArray a elemanları atıyorum. newldiğimde kaybolur.

            items = new T[items.Length+1];  //dizimin eleman sayısı 0 dı 1 artırdım. öylece bir elemanlık yer açtım.
            
            

            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];   //tempArray deki elemanları sırasıyla alıyorum.
            }

            items[items.Length - 1] = item;   // dizimin eleman sayısı -1 . elemanına engini atıyorum.
        }
    }
}
