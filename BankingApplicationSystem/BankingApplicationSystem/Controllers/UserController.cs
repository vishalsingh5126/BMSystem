using BankingApplicationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApplicationSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        BankManagementDataBase _db = new BankManagementDataBase();  
        public ActionResult Index()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 17; i++)
            {
                if(i!=1)
                    r += random.Next(0, 9).ToString();
                else
                    r += random.Next(1, 9).ToString();
            }
            Int64 acc_num= Convert.ToInt64(r);
            ViewBag.ACC_NUM = acc_num;
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(USER_DETAILS model)
        {
            _db.USER_DETAILS.Add(model);
            _db.SaveChanges();
            ViewBag.Message = "Account Details Added successfully.";
            return View("~/Views/Home/BankManagementSystem.cshtml");
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
                _db.Dispose();
            base.Dispose(disposing);
        }

    }
}