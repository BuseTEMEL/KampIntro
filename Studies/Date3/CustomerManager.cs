using System;
using System.Collections.Generic;
using System.Text;

namespace Date3
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added : \n"+ customer.Adi + " " + customer.Soyadi);
        }

        public void List(Customer[] customers)
        {
            Console.WriteLine("Costumer Listed :");
            foreach (Customer customerItem in customers)
            {
                Console.WriteLine(customerItem.Adi + " " + customerItem.Soyadi);
            }

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted : \n" + customer.Adi + " " + customer.Soyadi);
        }

    }
}
