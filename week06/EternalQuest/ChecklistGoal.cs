public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints) 
        : base(name, description, points)
    {
        _target = target;
        _current = 0;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _current++;
        if (_current == _target)
        {
            _isComplete = true;
            return _basePoints + _bonusPoints;
        }
        return _basePoints;
    }

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} -- Completed {_current}/{_target} times";
    }
}

