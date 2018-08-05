using BankingApplicationSystem.EntityFrameworkLayer;
using BankingApplicationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Services
{
    public class PerformTransactionService
    {
        public int updateTransactionDetails(TRANSACTION_DETAILS model, USER_DETAILS[] query)
        {
            if (model.TRANSACTION_TYPE == "Withdrawal")
            {
                if (query[0].ACCOUNT_TYPE.ToString().ToLower() == "saving")
                {
                    if (query[0].ACCOUNT_BALANCE - model.ACCOUNT_BALANCE < 5000)
                        return 0;
                    else
                    {
                        if (query[0].ACCOUNT_BALANCE - model.ACCOUNT_BALANCE < 0)
                        {
                            return 0;
                        }
                        else
                        {
                            PerformTransaction refer = new PerformTransaction();
                            int result = refer.updateTransactionDetailsDebit(model, query);
                            return 1;
                        }
                    }
                }
                else
                {
                    if (query[0].ACCOUNT_BALANCE - model.ACCOUNT_BALANCE < 0)
                    {
                        return 0;
                    }
                    else
                    {
                        PerformTransaction refer = new PerformTransaction();
                        int result = refer.updateTransactionDetailsDebit(model, query);
                        return 1;
                    }
                }
            }
            else
            {
                PerformTransaction refer = new PerformTransaction();
                int result = refer.updateTransactionDetailsCredit(model, query);
                return 1;
            }
        }
    }
}