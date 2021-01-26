using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    public interface ICampaign
    {
        double CalculateCampaign(IGame game);
    }
}
