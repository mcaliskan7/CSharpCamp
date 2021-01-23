using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport loan payment plan is calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
