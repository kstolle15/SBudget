using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SBudget.Areas.Identity.Data
{
    public class Budget
    {
        public int ID { get; set; }

        public SBudgetUser User { get; set; }

        public List<Income> Incomes { get; set; }

        public List<Expense> Expenses { get; set; }

        public List<Transfer> Transfers { get; set; }

        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }
    }
}
