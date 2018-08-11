using BankingApplicationSystem.EntityFrameworkLayer;
using BankingApplicationSystem.Models.Home_Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Services
{
    public class ApplyHomeLoanService
    {
        public string insertHomeLoanDetails(Apply_Home_Loan homeloan)
        {
            ApplyHomeLoan refer = new ApplyHomeLoan();
            string result = refer.insertHomeLoanDetails(homeloan);
            return result;
        }
    }
}