using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SMSLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sent SMS.");
        }
    }
}