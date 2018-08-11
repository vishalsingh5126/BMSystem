using BankingApplicationSystem.EntityFrameworkLayer;
using BankingApplicationSystem.Models.Home_Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Services
{
    public class ViewHomeLoanService
    {
        public Apply_Home_Loan[] retrieveHomeLoanDetails(long AccountNumber, string LoanId)
        {
            ViewHomeLoan refer = new ViewHomeLoan();
            Apply_Home_Loan[] result = refer.retrieveHomeLoanDetails(AccountNumber, LoanId);
            return result;
        }
    }
}