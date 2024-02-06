using System;

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

    public SeasonParking(ICalculateChargeStrategy calChargeStrategy)
    {
        _calChargeStrategy = calChargeStrategy;
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
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int AvailablePasses { get; set; }

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
    public DateTime DateOfIssue { get; set; }
    public decimal MaxDailyRate { get; set; }

    public decimal CalculateCharge()
    {
    
        return 0; // placeholder
    }
}
