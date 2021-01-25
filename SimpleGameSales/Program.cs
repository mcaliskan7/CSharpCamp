using System;
using System.Collections.Generic;

namespace SimpleGameSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple game sales simulation.
            Console.WriteLine("_________________________________");

            //Adding New Games
            Game game1 = new Game();
            game1.ID = 1;
            game1.Name = "Read Dead Redemption 2";
            game1.Price = 299;

            Game game2 = new Game();
            game2.ID = 2;
            game2.Name = "Tomb Raider 2013";
            game2.Price = 39;

            Game game3 = new Game();
            game3.ID = 3;
            game3.Name = "The Witcher 3";
            game3.Price = 99;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            //Removing a Game
            gameManager.Remove(game2);

            //Updating a Game
            gameManager.Update(game1);

            //Registration of New Gamers
            Gamer gamer1 = new Gamer();
            gamer1.ID = 1;
            gamer1.NationalityID = "24567891236";
            gamer1.FirstName = "Engin";
            gamer1.LastName = "Demiroğ";
            gamer1.BirthDate = "06.01.1985";
            gamer1.UserName = "engindemirog";

            Gamer gamer2 = new Gamer();
            gamer2.ID = 2;
            gamer2.NationalityID = "78954236174";
            gamer2.FirstName = "Merve";
            gamer2.LastName = "Çalışkan";
            gamer2.BirthDate = "16.08.1999";
            gamer2.UserName = "mcaliskan7";

            Gamer gamer3 = new Gamer();
            gamer3.ID = 3;
            gamer3.NationalityID = "47581632982";
            gamer3.FirstName = "felix";
            gamer3.LastName = "Kjellberg";
            gamer3.BirthDate = "24.10.1989";
            gamer3.UserName = "PewDiePie";

            List<IGamerCheckService> checkServices = new List<IGamerCheckService> 
            { new EDevletService(), new MernisService() };

            GamerManager gamerManager = new GamerManager();
            gamerManager.Register(gamer1, checkServices);
            gamerManager.Register(gamer2, checkServices);
            gamerManager.Register(gamer3, checkServices);

            //Deleting a Gamer
            gamerManager.Delete(gamer2);

            //Updating a Gamer
            gamerManager.Update(gamer1);

            //Adding New Campaigns
            Campaign campaign1 = new Campaign();
            campaign1.ID = 1;
            campaign1.Name = "Student Campaign";
            campaign1.Discount = 30;

            Campaign campaign2 = new Campaign();
            campaign2.ID = 2;
            campaign2.Name = "Turkey Campaign";
            campaign2.Discount = 20;

            Campaign campaign3 = new Campaign();
            campaign3.ID = 3;
            campaign3.Name = "Happy New Year Campaign";
            campaign3.Discount = 25;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);

            //Removing a Campaign
            campaignManager.Remove(campaign3);

            //Updating a Campaign
            campaignManager.Update(campaign2);

            //Purchasing a Game
            SalesManager salesManager = new SalesManager();

            salesManager.Purchase(game1, gamer1, new List<Campaign> { campaign2, campaign3 });
            salesManager.Purchase(game2, gamer2, new List<Campaign> { campaign1, campaign2, campaign3 });
            salesManager.Purchase(game3, gamer3, new List<Campaign> { campaign3 });

            //Refund for a Game
            salesManager.Refund(game2, gamer2);
        }
    }
}