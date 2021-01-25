using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameSales
{
    class EDevletService : IGamerCheckService
    {
        public void Verify(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.UserName + " Verified by E-Devlet!");
        }
    }
}