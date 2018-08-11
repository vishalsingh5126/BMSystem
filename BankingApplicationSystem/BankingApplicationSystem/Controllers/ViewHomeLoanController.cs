using BankingApplicationSystem.Models.Home_Loan;
using BankingApplicationSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApplicationSystem.Controllers
{
    public class ViewHomeLoanController : Controller
    {
        // GET: ViewHomeLoan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult searchHomeLoanDetails(long AccountNumber, string LoanId)
        {

            ViewHomeLoanService reference = new ViewHomeLoanService();
            Apply_Home_Loan[] T_Details = reference.retrieveHomeLoanDetails(AccountNumber, LoanId);
            var list = T_Details.ToList();
            return View("View", list);
        }
    }
}