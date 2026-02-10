public abstract class Goal
{
    string _shortName;
    string _description;
    int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string details;
        if (IsComplete())
        {
            details = "X";
        }
        else
        {
            details = " ";
        }
        return $"[{details}] {_shortName} - ({_description})";
    }

}