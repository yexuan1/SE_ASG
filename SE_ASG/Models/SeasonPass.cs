using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{

    // Define the interface for the strategy
    public interface ICalculateCharge
    {
        decimal CalculateCharge();
    }

    // Define the context class
    public class SeasonParking
    {
        private Boolean IsPaid { get; set; }

        public String PassType { get; set; }
        public int PassNumber { get; set; }

        public StatusState status;

        public StatusState active;

        public StatusState expired;

        public StatusState terminated;

        private ICalculateCharge _calChargeStrategy;

        public SeasonParking(ICalculateCharge calChargeStrategy)
        {
            _calChargeStrategy = calChargeStrategy;
            active = new Active(this);
            expired = new Expired(this);
            terminated = new Terminated(this);

            status = active;
        }

        public void setState(StatusState status)
        {
            this.status = status;
        }

        public decimal CalculateCharge()
        {
            return _calChargeStrategy.CalculateCharge();
        }
    }


    public enum IStatusState
    {
        Active,
        Expired,
        Terminated
    }


    public class MonthlySeasonPass : ICalculateCharge
    {
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private int AvailablePasses { get; set; }

        public decimal CalculateCharge()
        {
            // Implementation
            return 0; 
        }
    }

    // Define NoPass subclass
    public class NoPass : ICalculateCharge
    {
        public decimal CalculateCharge()
        {
            // Implementation
            return 0; 
        }
    }

    // Define DailySeasonPass subclass
    public class DailySeasonPass : ICalculateCharge
    {
        private DateTime DateOfIssue { get; set; }
        private decimal MaxDailyRate { get; set; }

        public decimal CalculateCharge()
        {
            // Implementation
            return 0; 
        }
    }

}
