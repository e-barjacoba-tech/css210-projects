using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //It is better if this method returns the number of points earned that just being a void
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        string details = $"[ ] {_shortName} ({_description})";
        if (IsComplete())
        {
            details = $"[X] {_shortName} ({_description})";
        }
        return details;
    }
    public string GetName()
    {
        return _shortName;
    }

}