using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Models
{
    public class TRANSACTION_DETAILS
    {
        public int ID { get; set; }
        [Index(IsUnique = true)]
        [Display(Name = "Transaction ID")]
        public Int64 TRANSACTION_ID { get; set; }
        [Display(Name = "Transaction Description")]
        public string TRANSACTION_DESCRIPTION { get; set; }
        [Display(Name = "Transaction Type")]
        public string TRANSACTION_TYPE { get; set; }
        
        [Range(0, Int64.MaxValue, ErrorMessage = "Acount number should not contain characters")]
        //[StringLength(16, MinimumLength = 16, ErrorMessage = "Acount number should be of 16 digits")]
        [Display(Name = "Account Number")]
        public Int64 account_number { get; set; }
        [Display(Name = "Transaction Amount")]
        public float ACCOUNT_BALANCE { get; set; }
    }
}