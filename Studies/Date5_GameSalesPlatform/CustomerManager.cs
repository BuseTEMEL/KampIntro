using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine( customer + " müşterisi eklendi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer + " müşterisinin bilgileri güncellendi.");
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine(customer + " müşterisi silindi.");
        }

    }
}
