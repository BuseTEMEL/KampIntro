using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] item = new string[2];
            

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;  //2 mobilyaya karşılık gelir. numaralandırmanın nedeni; kategorinin adı değişirse kodu değil de veri kaynağını değiştiririz.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //bu şekilde de yazılabilir.
            Product product2 = new Product { Id = 2, CategoryId=5, ProductName = "Kalem", UnitsInStock=5, UnitPrice=35 };


            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();  //örnek oluşturma class ın örneği
            //stack         //heap
            
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
           

            productManager.Topla(3,6);
            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu * 2);
            
        }
    }
}
