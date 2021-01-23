using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager personalFinanceLoanManager = new PersonalFinanceLoanManager();
            ILoanManager transportLoanManager = new TransportLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            List<ILoanManager> loans = new List<ILoanManager> { new PersonalFinanceLoanManager(), new TransportLoanManager(), new MortgageLoanManager(), new ArtisanLoanManager()};
            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService(), new SMSLoggerService()};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(loans, loggers);

            //List<ILoanManager> loans = new List<ILoanManager>() {personalFinanceLoanManager, transportLoanManager }; 
            //applicationManager.LoanPreNotification(loans);
        }
    }
}