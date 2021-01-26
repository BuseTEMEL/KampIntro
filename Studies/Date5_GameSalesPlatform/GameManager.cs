using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    public class GameManager
    {
        public void Add(List<IGame> games)
        {
            foreach (var item in games)
            {
                Console.WriteLine(item.GameName + " SEPETE EKLENDİ");
            }
        }
    }
}
