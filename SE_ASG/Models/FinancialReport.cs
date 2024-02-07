using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class FinancialReport
    {
        public DateOnly Month { get; set; }

        public FinancialReport()
        {
            this.Month = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
