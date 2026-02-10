public class ChecklistGoal : Goal
{   
    int _amountCompleted;
    int _target;
    int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted >= _target)
        {
            return 0;
        }
        _amountCompleted ++;

        if (_amountCompleted == _target)
        {
            return GetPoints() + _bonus; 
        }
        
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetDetailsString()
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
        return $"[{details}] {GetName()} - ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
    }
}