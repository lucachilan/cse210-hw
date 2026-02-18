using System.Data;

public abstract class Activity
{
    private string _date;
    private int _duration;

    public void SetDate (string date)
    {
        _date = date;
    }
    public string GetDate(){
        return _date;   
    }
    public void SetDuration (int duration)
    {
        _duration = duration;
    }
    public int GetDuration(){
        return _duration;   
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} ({_duration} min) - Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace {GetPace():0.0}";
    }
    
}
    