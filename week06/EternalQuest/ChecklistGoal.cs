using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
    }

    public override int RecordEvent()
    {
        if(IsComplete())
        {
            _points += _bonus;
            return _points;
        }
        else 
        {
            _amountCompleted += 1;
            return _points;
        }
    }

    public override bool IsComplete()
    {
       if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string details = $"[ ] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        if (IsComplete())
        {
            details =  $"[X] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        return details;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        return representation;

    }
}