using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameSales
{
    class GamerManager
    {
        public void Register(Gamer gamer,List<IGamerCheckService> checkServices)
        {
            foreach (var checkService in checkServices)
            {
                checkService.Verify(gamer);
            }

            Console.WriteLine("Welcome, " + gamer.UserName + ", Registration Successful!");
            Console.WriteLine("_________________________________");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Hey, " + gamer.UserName + "! It looks better now!");
            Console.WriteLine("_________________________________");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Goodbye, " + gamer.UserName + "! We'll miss you!");
            Console.WriteLine("_________________________________");
        }
    }
}