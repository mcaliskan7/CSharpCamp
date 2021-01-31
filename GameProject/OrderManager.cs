using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Sell(Gamer gamer)
        {
            Console.WriteLine("Hello, " + gamer.FirstName + ". Order Successful!");
         }

    }
}