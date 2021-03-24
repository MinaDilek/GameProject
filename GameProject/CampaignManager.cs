using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void DeletedCampaign(Campaign campaign)
        {
            Console.WriteLine("Deleted Campaign");
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine("New Campaign");
        }

        public void UpdatedCampaign(Campaign campaign)
        {
            Console.WriteLine("Updated Campaign");
        }
    }
}
