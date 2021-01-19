using System;

namespace Date3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Adi = "Özkan";
            customer1.Soyadi = "TORAMAN";
            customer1.City = "İstanbul";
            customer1.District = "Kağıthane";
            customer1.Birthdate = "24.06.1989";
            customer1.Gender = 'E';

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Adi = "Buse";
            customer2.Soyadi = "TEMEL";
            customer2.City = "İstanbul";
            customer2.District = "Kağıthane";
            customer2.Birthdate = "23.05.2000";
            customer2.Gender = 'K';

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Adi = "Gözde ";
            customer3.Soyadi = "TÜRKMEN";
            customer3.City = "Adana";
            customer3.District = "Yüreğir";
            customer3.Birthdate = "07.10.1997";
            customer3.Gender = 'K';

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine("--------------");
            customerManager.List(customers);
            Console.WriteLine("--------------");
            customerManager.Delete(customer3);

            Console.ReadKey();

        }

    }
}
