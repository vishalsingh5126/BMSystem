using BankingApplicationSystem.Models;
using BankingApplicationSystem.Models.Home_Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.EntityFrameworkLayer
{
    public class ApplyHomeLoan
    {
        BankManagementDataBase _db = new BankManagementDataBase();
        public string insertHomeLoanDetails(Apply_Home_Loan homeloan)
        {
            try
            {
                var query = _db.Apply_Home_Loan.Where(r => r.Loan_ID == homeloan.Loan_ID);
                if (query.Count() == 0)
                {
                    _db.Apply_Home_Loan.Add(homeloan);
                    _db.SaveChanges();
                    return "1";
                }
                else
                    return "An error occured while processing you request.";
            }
            catch (Exception)
            {
                return "An error occured while processing you request.";
            }
        }
    }
}