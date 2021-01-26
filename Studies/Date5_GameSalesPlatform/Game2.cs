using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    public class Game2 : IGame
    {
        public string GameName { get; set; } = "GAME2";
        public string GameType { get; set; } = "CROSSWORD";
        public double GameReviewScore { get; set; } = 4.5;
        public double GamePrice { get; set; } = 49.90;
    }
}
