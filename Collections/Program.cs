using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Tesla", "Planck", "Maxwell", "Einstein" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "Edison";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);

            List<string> names = new List<string> { "Tesla", "Planck", "Maxwell", "Einstein" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names.Add("Edison");
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);
        }
    }
}
