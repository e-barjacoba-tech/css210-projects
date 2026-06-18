using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Pace()
    {
        return Math.Round(_minutes/_distance, 2);
    }

    public override double Speed()
    {
        return Math.Round((_distance/_minutes)*60, 2);
    }

    public override string GetSummary()
    {
        return $"{_date} | Running : {Distance()} kilometers, {Speed()}kph, {Pace()}min per km";
    }
}