using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Models.ViewTransaction
{
    public class View_Transaction
    {
        [Display(Name = "Transaction ID")]
        public Int64 TRANSACTION_ID { get; set; }
        [Range(0, Int64.MaxValue, ErrorMessage = "Acount number should not contain characters")]
        //[StringLength(16, MinimumLength = 16, ErrorMessage = "Acount number should be of 16 digits")]
        [Display(Name = "Account Number")]
        public Int64 account_number { get; set; }
    }
}