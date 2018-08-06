using BankingApplicationSystem.Models;
using BankingApplicationSystem.Models.EducationLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.EntityFrameworkLayer
{
    
    public class ViewEducationLoan
    {
        BankManagementDataBase _db = new BankManagementDataBase();
        public Edu_Loan_Details[] retrieveEducationLoanDetails(long AccountNumber, int identificationCardNumber)
        {
            if (identificationCardNumber == 0)
            {
                var query3 = _db.Edu_Loan_Details.Where(r => r.EDU_LOAN_ACCOUNT_NUMBER == AccountNumber);
                Edu_Loan_Details[] T_Details = query3.ToArray();
                return T_Details;
            }
            else
            {
                var query3 = _db.Edu_Loan_Details.Where(r => r.ID_CARD_NUMBER == identificationCardNumber);
                Edu_Loan_Details[] T_Details = query3.ToArray();
                return T_Details;
            }
        }
    }
}