using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.ID = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.CountryID = "12345678910";

            Corporate customer2 = new Corporate();
            customer2.ID = 2;
            customer2.CustomerNo = "67890";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "457896523";

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
