using System.ComponentModel;

public class Running : Activity
{
    private double _distanceInMiles; //in miles

    public Running (string date, int duration, double distance)
    {
        SetDate(date);
        SetDuration(duration);
        _distanceInMiles = distance;
    }
    public void SetDistance(double distance)
    {
        _distanceInMiles = distance;
    }
    public double GetRunningDistance()
    {
        return _distanceInMiles;
    }
    public override double GetDistance()
    {
        return _distanceInMiles;   
    }

    public override double GetSpeed()
    {
        // mph
        return (_distanceInMiles/GetDuration()) * 60 ;
    }
    public override double GetPace()
    {
        // miles per minute
        return GetDuration()/_distanceInMiles;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";    
    }
}