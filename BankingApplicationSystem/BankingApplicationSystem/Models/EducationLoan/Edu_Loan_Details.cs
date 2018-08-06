using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Models.EducationLoan
{
    public class Edu_Loan_Details
    {
        public int id { get; set; }
        public string EDUCATION_LOAN_ID { get; set; }
        [Display(Name = "Account Number")]
        public long ACCOUNT_NUMBER { get; set; }
        public long EDU_LOAN_ACCOUNT_NUMBER { get; set; }
        [Display(Name = "Loan Amount")]
        [Required]
        public long EDU_LOAN_AMOUNT { get; set; }
        [Display(Name = "Loan Apply Date")]
        [Required]
        public DateTime EDU_LOAN_APPLY_DATE { get; set; }
        [Display(Name = "Loan Duration")]
        [Required]
        public int EDU_LOAN_DURATION { get; set; }
        [Display(Name = "Course Name")]
        [Required]
        public string COURSE_NAME { get; set; }
        [Display(Name = "Course Fee")]
        [Required]
        public long COURSE_FEE { get; set; }
        [Display(Name = "Father Name")]
        [Required]
        public string FATHER_NAME { get; set; }
        [Display(Name = "ID Number")]
        [Required]
        public int ID_CARD_NUMBER { get; set; } 
        [Display(Name = "Father’s Annual Income")]
        [Required]
        public long FATHER_ANNUAL_INCOME { get; set; }
    }
}