using BankingApplicationSystem.Models;
using BankingApplicationSystem.Models.EducationLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.EntityFrameworkLayer
{
    public class ApplyEducationLoan
    {
        BankManagementDataBase _db = new BankManagementDataBase();
        public string insertEducationLoanDetails(Edu_Loan_Details educationloanVO)
        {
            try
            {
                var query = _db.Edu_Loan_Details.Where(r => r.EDUCATION_LOAN_ID == educationloanVO.EDUCATION_LOAN_ID);
                if (query.Count() == 0)
                {
                    _db.Edu_Loan_Details.Add(educationloanVO);
                    _db.SaveChanges();
                    return "1";
                }
                else
                    return "An error occured while processing you request.";
            }
            catch(Exception)
            {
                return "An error occured while processing you request.";
            }
        }
     }
}