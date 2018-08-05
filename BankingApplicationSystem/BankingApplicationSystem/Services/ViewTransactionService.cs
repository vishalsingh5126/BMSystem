using BankingApplicationSystem.EntityFrameworkLayer;
using BankingApplicationSystem.Models;
using BankingApplicationSystem.Models.ViewTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Services
{
    public class ViewTransactionService
    {
        public TRANSACTION_DETAILS[] retrieveTransactionDetails(long account_number, long TRANSACTION_ID)
        {
            ViewTransaction refer = new ViewTransaction();
            TRANSACTION_DETAILS[] result = refer.retrieveTransactionDetails(account_number, TRANSACTION_ID);
            return result;
        }
    }
}