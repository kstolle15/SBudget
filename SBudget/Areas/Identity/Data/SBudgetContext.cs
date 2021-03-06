﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SBudget.Areas.Identity.Data;

namespace SBudget.Data
{
    public class SBudgetContext : IdentityDbContext<SBudgetUser>
    {
        public SBudgetContext(DbContextOptions<SBudgetContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Account>().ToTable("Accounts");
            builder.Entity<Income>().ToTable("Incomes");
            builder.Entity<Expense>().ToTable("Expenses");
            builder.Entity<Transfer>().ToTable("Transfers");
            builder.Entity<Budget>().ToTable("Budgets");
        }
    }
}
