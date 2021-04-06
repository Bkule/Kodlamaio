using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is added to the system.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is deleted from the system.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is updated to the system.");
        }
    }
}
