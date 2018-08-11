using BankingApplicationSystem.Models;
using BankingApplicationSystem.Models.Home_Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.EntityFrameworkLayer
{
    public class ViewHomeLoan
    {
        BankManagementDataBase _db = new BankManagementDataBase();
        public Apply_Home_Loan[] retrieveHomeLoanDetails(long AccountNumber, string LoanId)
        {
            if (LoanId == "0")
            {
                var query3 = _db.Apply_Home_Loan.Where(r => r.Home_Loan_Acc_Number == AccountNumber);
                Apply_Home_Loan[] T_Details = query3.ToArray();
                return T_Details;
            }
            else
            {
                var query3 = _db.Apply_Home_Loan.Where(r => r.Loan_ID == LoanId);
                Apply_Home_Loan[] T_Details = query3.ToArray();
                return T_Details;
            }
        }
    }
}