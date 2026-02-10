using System.ComponentModel;

public class SimpleGoal : Goal
{
    bool _isComplete;

    public SimpleGoal(string name, string description, int points):base(name, description, points){}

    public void SetIsComplete(bool state)
    {
        _isComplete = state;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}