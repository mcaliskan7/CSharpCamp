using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage loan payment plan is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
