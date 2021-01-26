using System;
using System.Collections.Generic;

namespace Date5_GameSalesPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, TcNu = "12345", Name = "ÖZKAN", Surname = "TORAMAN", Birthdate = "24/06/1989" };
            Customer customer2 = new Customer() { Id = 2, TcNu = "67890", Name = "BUSE", Surname = "TEMEL", Birthdate = "23/05/2000" };

            IGame game1 = new Game1() { GameName = "GAME1", GameType = "WAR", GameReviewScore = 4.8, GamePrice = 99.90 };
            IGame game2 = new Game2() { GameName = "GAME2", GameType = "CROSSWORD", GameReviewScore = 4.5, GamePrice= 49.90 };
            IGame game3 = new Game3() { GameName = "GAME3", GameType = "RACE", GameReviewScore = 3.2, GamePrice = 24.99 };

            

            List<IGame> games = new List<IGame>() { game1, game2};

            Console.Write("TC Kimlik Numaranız: ");
            string TC = Console.ReadLine();
            Console.Write("Adınız: ");
            string Name = Console.ReadLine().ToUpper();
            Console.Write("Soyadınız: ");
            string Surname = Console.ReadLine().ToUpper();
            Console.Write("Doğum Tarihiniz (GG/AA/YY): ");
            string Birthdate = Console.ReadLine();
            Console.WriteLine("___________________");

            CustomerInformationSQL customerInformationSQL = new CustomerInformationSQL();


            GameManager gameManager = new GameManager();

            

            if (TC == customerInformationSQL.Tc1.ToString())
            {
                Console.WriteLine("Bilgileriniz Doğrulandı.");
                Console.WriteLine("___________________");
                gameManager.Add(new List<IGame>() { game1, game2 });
            }

            else
            {
                Console.WriteLine("Bilgileriniz Doğrulanamadı.");
            }

            Console.WriteLine("___________________");

            

            SalesManager salesManager = new SalesManager();
            salesManager.Add(customer1, new List<IGame> {game1,game2}, new StudentDiscount());

            

        }
    }
}
