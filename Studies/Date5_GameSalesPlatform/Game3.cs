using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    public class Game3 : IGame
    {
        public string GameName { get; set; } = "GAME3";
        public string GameType { get; set; } = "RACE";
        public double GameReviewScore { get; set; } = 3.2;
        public double GamePrice { get; set; } = 24.99;
    }
}
