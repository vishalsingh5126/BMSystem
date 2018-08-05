using BankingApplicationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.EntityFrameworkLayer
{
    public class PerformTransaction
    {
        BankManagementDataBase _db = new BankManagementDataBase();
        public int updateTransactionDetailsDebit(TRANSACTION_DETAILS model, USER_DETAILS[] query)
        {
            _db.TRANSACTION_DETAILS.Add(model);
            _db.SaveChanges();
            Int64 ACC_NUM = Convert.ToInt64(model.account_number);
            var query1 = _db.USER_DETAILS.Where(r => r.ACCOUNT_NUMBER == ACC_NUM);
            foreach (USER_DETAILS userdetail in query1)
            {
                userdetail.ACCOUNT_BALANCE = query[0].ACCOUNT_BALANCE - model.ACCOUNT_BALANCE;
            }
            _db.SaveChanges();
            return 0;
        }

        public int updateTransactionDetailsCredit(TRANSACTION_DETAILS model, USER_DETAILS[] query)
        {
            _db.TRANSACTION_DETAILS.Add(model);
            _db.SaveChanges();
            Int64 ACC_NUM = Convert.ToInt64(model.account_number);
            var query1 = _db.USER_DETAILS.Where(r => r.ACCOUNT_NUMBER == ACC_NUM);
            foreach (USER_DETAILS userdetail in query1)
            {
                userdetail.ACCOUNT_BALANCE = query[0].ACCOUNT_BALANCE + model.ACCOUNT_BALANCE;
            }
            _db.SaveChanges();
            return 0;
        }
    }
}