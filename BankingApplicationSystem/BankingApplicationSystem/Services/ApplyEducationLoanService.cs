using BankingApplicationSystem.EntityFrameworkLayer;
using BankingApplicationSystem.Models.EducationLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Services
{
    public class ApplyEducationLoanService
    {
        public string insertEducationLoanDetails(Edu_Loan_Details educationloanVO)
        {
            ApplyEducationLoan refer = new ApplyEducationLoan();
            string result = refer.insertEducationLoanDetails(educationloanVO);
            return result;
        }
    }
}