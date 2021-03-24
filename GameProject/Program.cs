using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.PlayerName = "Mina ";
            player1.PlayerLastName = "Dilek";
            player1.NationalityId = 123456910;
            player1.DateOfBirth = 1997;

            PlayerManager playerManager = new PlayerManager();
            playerManager.SignUp(player1);

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "GTA V";
            game1.GamePrice = 169;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Black Friday";
            campaign1.DiscountRate = 45;

            GameSellManager gameSellManager = new GameSellManager();
            gameSellManager.SellWithNormal(player1, game1);


        }
    }
}
