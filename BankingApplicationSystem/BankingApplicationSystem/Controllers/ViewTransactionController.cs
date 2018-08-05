using BankingApplicationSystem.Models;
using BankingApplicationSystem.Models.ViewTransaction;
using BankingApplicationSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApplicationSystem.Controllers
{
    public class ViewTransactionController : Controller
    {
        // GET: ViewTransaction
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult searchUserTransaction(long account_number, long TRANSACTION_ID)
        {
                ViewTransactionService reference = new ViewTransactionService();
                TRANSACTION_DETAILS[] T_Details = reference.retrieveTransactionDetails(account_number, TRANSACTION_ID);
            var list = T_Details.ToList();
            return View("View",list);
        }
     }
}