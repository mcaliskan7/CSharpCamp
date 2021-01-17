using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 1957486237;
            customer1.Name = "Nikola";
            customer1.Surname = "Tesla";
            customer1.Age = 86;
            customer1.Country = "Croatia";

            Customer customer2 = new Customer();
            customer2.ID = 1647183578;
            customer2.Name = "James Clerk";
            customer2.Surname = "Maxwell";
            customer2.Age = 48;
            customer2.Country = "Scotland";

            Customer customer3 = new Customer();
            customer3.ID = 1746921682;
            customer3.Name = "Max";
            customer3.Surname = "Planck";
            customer3.Age = 89;
            customer3.Country = "Germany";

            Customer customer4 = new Customer();
            customer4.ID = 1748612793;
            customer4.Name = "Ada";
            customer4.Surname = "Lovelace";
            customer4.Age = 36;
            customer4.Country = "England";

            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2, customer3};
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);

            customerManager.GetCustomerList(customers);

            customers = new Customer[] { customer1, customer4 };
            customerManager.RemoveCustomer(customer2);
            customerManager.RemoveCustomer(customer3);
            customerManager.AddCustomer(customer4);

            customerManager.GetCustomerList(customers);
        }
    }
}
