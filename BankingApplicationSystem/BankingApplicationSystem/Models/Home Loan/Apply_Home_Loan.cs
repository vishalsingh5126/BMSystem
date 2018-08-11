using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Models.Home_Loan
{
    public class Apply_Home_Loan
    {
        public int ID { get; set; }
        [Display(Name = "Loan ID")]
        [Required]
        public string Loan_ID { get; set; }
        [Display(Name = "Home Loan Account Number")]
        [Required]
        public long Home_Loan_Acc_Number { get; set; }
        [Display(Name = "Account Number")]
        [Required]
        public long Account_Number  { get; set; }
        [Display(Name = "Loan Amount")]
        [Required]
        public long Loan_Amount { get; set; }
        [Display(Name = "Loan Apply Date")]
        [Required]
        public DateTime Loan_Apply_Date { get; set; }
        [Display(Name = "Loan Duration")]
        [Required]
        public int Loan_Duration { get; set; }
        [Display(Name = "Annual Income")]
        public long Annual_Income { get; set; }
        [Display(Name = "Company Name")]
        [Required]
        public string Company_Name { get; set; }
        [Display(Name = "Designation")]
        [Required]
        public string Designation { get; set; }
        [Display(Name = "Total Experience")]
        [Required]
        public int Total_Experience { get; set; }
        [Display(Name = "Experience with Current Company")]
        [Required]
        public int Exp_Current_Company { get; set; }        
    }
}