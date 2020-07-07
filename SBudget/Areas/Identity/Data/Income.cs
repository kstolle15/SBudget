using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SBudget.Areas.Identity.Data
{
    public class Income
    {
        public int ID { get; set; }

        public Account Account { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public int Type { get; set; }
    }
}
