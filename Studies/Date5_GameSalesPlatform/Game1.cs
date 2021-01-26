using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    public class Game1 : IGame
    {
        public string GameName { get; set; } = "GAME1";
        public string GameType { get; set; } = "WAR";
        public double GameReviewScore { get; set; } = 4.8;
        public double GamePrice { get; set; } = 99.9;
    }
}
