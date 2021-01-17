using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Info = "Green Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Info = "Juicy";

            Product[] products = new Product[] { product1, product2 };

            //type-safe

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Info);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("------------Methods-----------");

            //instance
            //encapsulation

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            
        }
    }
}




//Don't Repeat Yourself - DRY - Clean Code - Best Practice