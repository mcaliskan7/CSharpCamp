using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal finance loan payment plan is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
