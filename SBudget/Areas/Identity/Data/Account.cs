using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SBudget.Areas.Identity.Data
{
    public class Account
    {
        public int ID { get; set; }
        
        public SBudgetUser user { get; set; }

        public int type { get; set; }

        public double balance { get; set; }

    }
}
