using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            gamer1.ID = 1;
            gamer1.BirthYear = 1999;
            gamer1.FirstName = "MERVE";
            gamer1.LastName = "ÇALIŞKAN";
            gamer1.IdentityNumber = 12345;

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            Campaign Student = new Campaign
            {
                Id = 1,
                Name = "Student",
                Discount = 50
            };
            campaignManager.Add(Student);

            OrderManager orderManager = new OrderManager();
            orderManager.Sell(gamer1);
        }
    }
}