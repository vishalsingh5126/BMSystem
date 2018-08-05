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
    }
}