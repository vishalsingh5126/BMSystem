using BankingApplicationSystem.Models;
using BankingApplicationSystem.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApplicationSystem.Controllers
{
    public class PerformTransactionController : Controller
    {
        //        // GET: PerformTransaction
        BankManagementDataBase _db = new BankManagementDataBase();
        BankManagementDataBase _db1 = new BankManagementDataBase();
        //        string l;
        public ActionResult Index()
{
    Random random = new Random();
    string r = "";
    int i;
    for (i = 1; i < 11; i++)
    {
        if (i != 1)
            r += random.Next(0, 9).ToString();
        else
            r += random.Next(1, 9).ToString();
    }
    Int64 Tra_id = Convert.ToInt64(r);
    ViewBag.TRA_ID = Tra_id;
    ViewBag.success = null;
    return View("PerformTransaction");
}

        public ActionResult CheckAccNumber(string acc_num)
        {
            Int64 ACC_NUM = Convert.ToInt64(acc_num);
            var query = _db.USER_DETAILS.Where(r => r.ACCOUNT_NUMBER == ACC_NUM);
            if (query.Count() != 0)
                return Json(query);
            else
                return View("PerformTransaction");
        }
        public ActionResult initiateTransaction(TRANSACTION_DETAILS model)
        {
            ViewBag.Message = "";
            int success = 0;
            var query = _db.USER_DETAILS.Where(r => r.ACCOUNT_NUMBER == model.account_number);
            USER_DETAILS[] userdetail = query.ToArray();
            PerformTransactionService service = new PerformTransactionService();
            success = service.updateTransactionDetails(model, userdetail);
            var query3 = _db1.USER_DETAILS.Where(r => r.ACCOUNT_NUMBER == model.account_number);
            USER_DETAILS[] updateduserdetail = query3.ToArray();
            string k = updateduserdetail[0].ACCOUNT_BALANCE.ToString();
            if (success == 1)
            {
                string l = "Transaction Successfully Completed. The balance available in your Account is "+k+".";
                ViewBag.Message = l;
            }
            else
            {
                if (userdetail[0].ACCOUNT_TYPE == "Salary")
                    ViewBag.Message = "You do not have sufficient fund in your account. Your account balance is " + k + ".";
                else
                    ViewBag.Message = "You should maintain minimum 5000 Rupee in your account. Your account balance is " + k + ".";
            }
            return View("~/Views/Home/BankManagementSystem.cshtml");
        }
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
                _db.Dispose();
            if (_db1 != null)
                _db1.Dispose();
            base.Dispose(disposing);
        }
    }
}