using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Models.ViewHomeLoan
{
    public class ViewHomeLoan
    {
        [Display(Name = "Loan ID")]
        public string Loan_ID { get; set; }
        [Display(Name = "Loan Account Number")]
        public long Loan_Account_Number { get; set; }
    }
}