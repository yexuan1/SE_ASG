using SE_ASG.Models;
using System;
using System.Collections.Generic;
using System.Linq;

// Define the interface for the strategy
public interface ICalculateCharge
{
    decimal CalculateCharge();
}

// Define the context class
public class SeasonParking
{
    public int PassNumber { get; set; }
    
    public StatusState Status { get; set; }

    private ICalculateCharge _calCharge;

    private StatusState Active;

    private StatusState Expired;

    private StatusState Terminated;

    private StatusState state;

    public void setState(StatusState state)
    {
        this.state = state;
    }

    public SeasonParking(ICalculateCharge calCharge)
    {
        _calCharge = calCharge;
        Active = new Active(this);
        Expired = new Expired(this);
        Terminated = new Terminated(this);

        state = Active;
    }

    public decimal CalculateCharge()
    {
        return _calCharge.CalculateCharge();
    }
}

public enum StatusState
{
    Active,
    Expired,
    Terminated
}

// Define MonthlySeasonPass subclass
public class MonthlySeasonPass : ICalculateCharge
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
public class NoPass : ICalculateCharge
{
    public decimal CalculateCharge()
    {
      
        return 0; // placeholder
    }
}

// Define DailySeasonPass subclass
public class DailySeasonPass : ICalculateCharge
{
    private DateTime DateOfIssue { get; set; }
    private decimal MaxDailyRate { get; set; }

    public decimal CalculateCharge()
    {
    
        return 0; // placeholder
    }
}
