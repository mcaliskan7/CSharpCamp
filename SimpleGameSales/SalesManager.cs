using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameSales
{
    class SalesManager
    {
        public void Purchase(Game game, Gamer gamer, List<Campaign> campaigns)
        {
            Console.WriteLine("Welcome, " + gamer.UserName + "!");

            double discount = 0;
            double gamePrice = game.Price;

            foreach (var campaign in campaigns)
            {
                discount += campaign.Discount;
                Console.WriteLine(campaign.Name + " Activated!");
            }

            gamePrice = gamePrice * (100 - discount) / 100;
            Console.WriteLine("Game Purchased! Fee Paid: " + gamePrice);
            Console.WriteLine("_________________________________");
        }

        public void Refund(Game game, Gamer gamer)
        {
            Console.WriteLine("Welcome, " + gamer.UserName + "!");
            Console.WriteLine("Refund Successful! Refund: " + game.Price);
            Console.WriteLine("_________________________________");
        }
    }
}