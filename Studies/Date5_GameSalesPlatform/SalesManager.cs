using System;
using System.Collections.Generic;
using System.Text;

namespace Date5_GameSalesPlatform
{
    public class SalesManager
    {
        public void Add(Customer customer, List<IGame> games, ICampaign campaign)
        {
            foreach (var item in games)
            {
                Console.WriteLine(customer.Name + " isimli müşteriye " + item.GameName + " oyunu " + campaign.CalculateCampaign(item) + " fiyatından verildi.");
            }
        }
        
    }
}
