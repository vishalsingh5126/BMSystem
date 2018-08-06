using BankingApplicationSystem.Models.EducationLoan;
using BankingApplicationSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApplicationSystem.Controllers
{
    public class ViewEducationLoanController : Controller
    {
        // GET: ViewEducationLoan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult searchEducationLoanDetails(long AccountNumber, int identificationCardNumber)
        {

            ViewEducationLoanService reference = new ViewEducationLoanService();
            Edu_Loan_Details[] T_Details = reference.retrieveEducationLoanDetails(AccountNumber, identificationCardNumber);
            var list = T_Details.ToList();
            return View("View", list);
        }
    }
}