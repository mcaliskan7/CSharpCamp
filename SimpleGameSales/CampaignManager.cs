using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameSales
{
    class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Added!");
            Console.WriteLine("_________________________________");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Updated!");
            Console.WriteLine("_________________________________");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Removed!");
            Console.WriteLine("_________________________________");
        }
    }
}