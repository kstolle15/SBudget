using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SBudget.Areas.Identity.Data
{
    public class Transfer
    {
        public int ID { get; set; }

        [Display(Name ="Old Account")]
        public Account OldAccount { get; set; }

        [Display(Name ="New Account")]
        public Account NewAccount { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
