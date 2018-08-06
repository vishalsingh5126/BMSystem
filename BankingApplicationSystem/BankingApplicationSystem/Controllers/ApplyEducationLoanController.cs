using BankingApplicationSystem.Models.EducationLoan;
using BankingApplicationSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApplicationSystem.Controllers
{
    public class ApplyEducationLoanController : Controller
    {
        // GET: ApplyEducationLoan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult initiateEducationLoan(Edu_Loan_Details educationloanVO)
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
            educationloanVO.EDU_LOAN_ACCOUNT_NUMBER = loan_acc_num;
            educationloanVO.EDUCATION_LOAN_ID = "EL_"+ educationloanVO.ID_CARD_NUMBER.ToString().Substring(0,5);
            ApplyEducationLoanService refer = new ApplyEducationLoanService();
            string result = refer.insertEducationLoanDetails(educationloanVO);
            if(result =="1")
            {
                string msg = "Loan applied successfully. Your Loan Account number is ."+ loan_acc_num.ToString();
                ViewBag.Message = msg;
            }
            else
            ViewBag.Message = result;
            return View("~/Views/Home/BankManagementSystem.cshtml");
        }
    }
}