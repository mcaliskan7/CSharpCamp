using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation
{
    class GamerManager:IGamerService
    {
        public void Add(Gamer gamer, EDevletService service)
        {
            service.Verify(gamer);
            Console.WriteLine("New gamer added!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer info updated!");
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("The gamer removed!");
        }
    }
}