public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int duration, double speed)
    {
        SetDate(date);
        SetDuration(duration);
        _speed = speed;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public double GetCyclingSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()} min) - Distance {GetDistance():0.0} miles, Speed {_speed:0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}