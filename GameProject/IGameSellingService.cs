using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameSellingService
    {
        void SellWithNormal(Player player, Game game);
        void SellWithCampaign(Player player, Game game, Campaign campaign);
    }
}