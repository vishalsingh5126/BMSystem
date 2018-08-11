using BankingApplicationSystem.Models.Home_Loan;
using BankingApplicationSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApplicationSystem.Controllers
{
    public class ApplyHomeLoanController : Controller
    {
        // GET: ApplyHomeLoan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult initiateHomeLoan(Apply_Home_Loan homeloan)
        {
            ViewBag.Message = "";
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 17; i++)
            {
                if (i != 1)
                    r += random.Next(0, 9).ToString();
                else
                    r += random.Next(1, 9).ToString();
            }
            Int64 loan_acc_num = Convert.ToInt64(r);
            homeloan.Home_Loan_Acc_Number = loan_acc_num;
            homeloan.Loan_ID = "HL-" + homeloan.Account_Number.ToString().Substring(13);
            ApplyHomeLoanService refer = new ApplyHomeLoanService();
            string result = refer.insertHomeLoanDetails(homeloan);
            if (result == "1")
            {
                string msg = "Loan applied successfully. Your Loan Account number is ." + loan_acc_num.ToString();
                ViewBag.Message = msg;
            }
            else
                ViewBag.Message = result;
            return View("~/Views/Home/BankManagementSystem.cshtml");
        }
    }
}