// EternalGoal.cs
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return _basePoints;
    }

    public override string GetStatus()
    {
        return $"[ ] {_name} (Eternal)";
    }
}

