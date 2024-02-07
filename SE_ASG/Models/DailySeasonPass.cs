using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class DailySeasonPass : SeasonParking
    {
        private DateOnly dateOfIssue {  get; set; }

        private double maxDailyRate { get; set; }

        public DailySeasonPass()
        {

        }

        // TODO: Implement this method.
        public void CalculateCharge()
        {

        }
    }
}
