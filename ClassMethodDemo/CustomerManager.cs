using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("____________________________________________" + 
                "\nHello " + customer.Name + " " + customer.Surname + ", Welcome!");
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("____________________________________________" + 
                "\nGoodbye " + customer.Name + " " + customer.Surname + ", Hope to See You Again!");
        }

        public void GetCustomerList(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("____________________________________________" +
                    "\nCustomer ID: " + customer.ID +
                    "\nName: " + customer.Name +
                    "\nSurname: " + customer.Surname +
                    "\nAge: " + customer.Age +
                    "\nCountry: " + customer.Country);
            }
        }
    }
}
