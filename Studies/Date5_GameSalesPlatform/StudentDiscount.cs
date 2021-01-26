using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    public class StudentDiscount : ICampaign
    {
        public double CalculateCampaign(IGame game)
        {
            return game.GamePrice * 0.65;
        }

    }
}
