using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void NewCampaign(Campaign campaign);
        void DeletedCampaign(Campaign campaign);
        void UpdatedCampaign(Campaign campaign);

    }
}
