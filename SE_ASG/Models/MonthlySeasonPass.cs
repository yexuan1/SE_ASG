using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class MonthlySeasonPass : SeasonParking
    {
        private DateOnly startDate {  get; set; }

        private DateOnly endDate { get; set; }

        private int availablePasses { get; set; }

        public MonthlySeasonPass()
        {

        }

        public double CalculateCharge()
        {
            return 0;
        }
    }
}
