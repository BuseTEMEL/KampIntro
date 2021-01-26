using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    public interface IGame
    {
        public string GameName { get; set; }
        public string GameType { get; set; }
        public double GameReviewScore { get; set; }
        public double GamePrice { get; set; }
    }
}
