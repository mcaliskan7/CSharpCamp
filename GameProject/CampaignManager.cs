using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Campaign Added!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name +" Campaign Deleted!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Campaign Updated!");
        }
    }
}