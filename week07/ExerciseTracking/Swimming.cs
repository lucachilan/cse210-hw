public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int duration, int laps)
    {
        SetDate(date);
        SetDuration(duration);
        _laps = laps;
    }
    public void SetLaps(int laps)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50 / 1000.0) * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}