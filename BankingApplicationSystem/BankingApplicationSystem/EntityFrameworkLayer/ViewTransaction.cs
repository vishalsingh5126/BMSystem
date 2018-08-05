using BankingApplicationSystem.Models;
using BankingApplicationSystem.Models.ViewTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.EntityFrameworkLayer
{
    public class ViewTransaction
    {
        BankManagementDataBase _db = new BankManagementDataBase();
        public TRANSACTION_DETAILS[]  retrieveTransactionDetails(long account_number, long TRANSACTION_ID)
        {
            if (TRANSACTION_ID == 0)
            {
                var query3 = _db.TRANSACTION_DETAILS.Where(r => r.account_number == account_number);
                TRANSACTION_DETAILS[] T_Details = query3.ToArray();
                return T_Details;
            }
            else
            {
                var query3 = _db.TRANSACTION_DETAILS.Where(r => r.TRANSACTION_ID == TRANSACTION_ID);
                TRANSACTION_DETAILS[] T_Details = query3.ToArray();
                return T_Details;
            }
        }
    }
}