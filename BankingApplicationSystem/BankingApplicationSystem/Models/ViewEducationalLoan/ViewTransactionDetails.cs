using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Models.ViewEducationalLoan
{
    public class ViewTransactionDetails
    {
        [Display(Name = "ID Number")]
        public int ID_CARD_NUMBER { get; set; }
        [Display(Name = "Loan Account Number")]
        public long EDU_LOAN_ACCOUNT_NUMBER { get; set; }
    }
}