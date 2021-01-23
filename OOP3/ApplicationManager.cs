using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void Apply(List<ILoanManager> loanManagers, List<ILoggerService> loggerServices)
        {
            //Evaluation of applicant information
            //Something else

            //Independent from loan type
            foreach (var loanManager in loanManagers)
            {
                loanManager.Calculate();
            }

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void LoanPreNotification(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}