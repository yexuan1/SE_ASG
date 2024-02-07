using SE_ASG.Models;
using System;

namespace SE_ASG.Models
{
    // Define the interface for the strategy
    public interface ICalculateChargeStrategy
    {
        decimal CalculateCharge();
    }

    // Define the context class
    public class SeasonParking
    {
        public int PassNumber { get; set; }

        public StatusState Status { get; set; }

        private ICalculateChargeStrategy _calChargeStrategy;

        private StatusState active;

        private StatusState expired;

        private StatusState terminated;

        public void setState(StatusState Status)
        {
            this.Status = Status;
        }

        public SeasonParking(ICalculateChargeStrategy calChargeStrategy)
        {
            active = new Active(this);
            expired = new Expired(this);
            terminated = new Terminated(this);
            _calChargeStrategy = calChargeStrategy;


            Status = active;
        }


        public decimal CalculateCharge()
        {
            return _calChargeStrategy.CalculateCharge();
        }
    }

    // Define status state enum
    public enum StatusState
    {
        Active,
        Inactive
    }

    // Define MonthlySeasonPass subclass
    public class MonthlySeasonPass : ICalculateChargeStrategy
    {
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private int AvailablePasses { get; set; }

        public decimal CalculateCharge()
        {

            return 0; // placeholder
        }
    }

    // Define NoPass subclass
    public class NoPass : ICalculateChargeStrategy
    {
        public decimal CalculateCharge()
        {

            return 0; // placeholder
        }
    }

    // Define DailySeasonPass subclass
    public class DailySeasonPass : ICalculateChargeStrategy
    {
        private DateTime DateOfIssue { get; set; }
        private decimal MaxDailyRate { get; set; }

        public decimal CalculateCharge()
        {

            return 0; // placeholder
        }
    }

}
