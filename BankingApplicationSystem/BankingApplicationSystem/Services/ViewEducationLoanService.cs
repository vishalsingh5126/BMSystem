using BankingApplicationSystem.EntityFrameworkLayer;
using BankingApplicationSystem.Models.EducationLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Services
{
    public class ViewEducationLoanService
    {
        public Edu_Loan_Details[] retrieveEducationLoanDetails(long AccountNumber, int identificationCardNumber)
        {
            ViewEducationLoan refer = new ViewEducationLoan();
            Edu_Loan_Details[] result = refer.retrieveEducationLoanDetails(AccountNumber, identificationCardNumber);
            return result;
        }
    }
}