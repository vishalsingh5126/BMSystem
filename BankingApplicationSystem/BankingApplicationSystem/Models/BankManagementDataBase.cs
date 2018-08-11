using BankingApplicationSystem.Models.EducationLoan;
using BankingApplicationSystem.Models.Home_Loan;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankingApplicationSystem.Models
{
    public class BankManagementDataBase : DbContext
    {
        public BankManagementDataBase() : base("DefaultConnection")
        { }
        public DbSet<USER_DETAILS> USER_DETAILS { get; set; }
        public DbSet<TRANSACTION_DETAILS> TRANSACTION_DETAILS { get; set; }
        public DbSet<Edu_Loan_Details> Edu_Loan_Details { get; set; }
        
            public DbSet<Apply_Home_Loan> Apply_Home_Loan { get; set; }
    }
}