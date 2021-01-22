using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 250;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                ID = 2,
                CategoryID = 5,
                ProductName = "Pencil",
                UnitPrice = 10,
                UnitsInStock = 15
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
