using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Models
{
    public class USER_DETAILS
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Acount Number")]
        [Index(IsUnique = true)]
        [Range(0, Int64.MaxValue, ErrorMessage = "Acount number should not contain characters")]
        //[StringLength(16, MinimumLength = 16, ErrorMessage = "Acount number should be of 16 digits")]
        public Int64 ACCOUNT_NUMBER { get; set; }
        [Display(Name = "Acount Type")]
        [Required]
        public string ACCOUNT_TYPE { get; set; }
        [Display(Name = "Acount Holder Name")]
        [Required]
        public string ACCOUNT_HOLDER_NAME { get; set; }
        [Display(Name = "Acount Balance")]
        [Required]
        public float ACCOUNT_BALANCE { get; set; }
    }
}