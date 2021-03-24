using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSellManager : IGameSellingService
    {
        private const string V = "indirimli almıs oldugunuz : ";

        public void SellWithCampaign(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("Sevgili Oyuncumuz: " + player.PlayerName, "almıs oldugunuz : " + game.GameName + "oyununu ,iyi günlerde kullanmanızı dileriz." + "oyun ücreti : " + game.GamePrice);
        }

        public void SellWithNormal(Player player, Game game)
        {
            Console.WriteLine("Sevgili oyuncumuz : " + player.PlayerName + player.PlayerLastName + " , almıs oldugunuz " + game.GameName + " oyununu iyi günlerde kullanmanızı dileriz ");
        }
    }
}
