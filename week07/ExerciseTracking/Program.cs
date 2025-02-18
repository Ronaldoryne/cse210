using System;
using System.Collections.Generic;

// Base class for all activities
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method that can be overridden if needed
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min)- " +
               $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }

    protected int GetMinutes()
    {
        return _minutes;
    }
}

// Running activity class
public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) 
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}

// Cycling activity class
public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) 
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}

// Swimming activity class
public class Swimming : Activity
{
    private int _laps;
    private const double METERS_TO_MILES = 0.000621371;
    private const int LAP_LENGTH_METERS = 50;

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LAP_LENGTH_METERS * METERS_TO_MILES;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}

// Program class with main method
public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type
        activities.Add(new Running(
            new DateTime(2024, 2, 18), 
            30, 
            3.0)); // 30 minutes, 3.0 miles

        activities.Add(new Cycling(
            new DateTime(2024, 2, 18), 
            45, 
            15.0)); // 45 minutes, 15.0 mph

        activities.Add(new Swimming(
            new DateTime(2024, 2, 18), 
            40, 
            20)); // 40 minutes, 20 laps

        // Display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}