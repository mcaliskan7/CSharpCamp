using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameSales
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Added!");
            Console.WriteLine("_________________________________");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Updated!");
            Console.WriteLine("_________________________________");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.Name + " Removed!");
            Console.WriteLine("_________________________________");
        }
    }
}