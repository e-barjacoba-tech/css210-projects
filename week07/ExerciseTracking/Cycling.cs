using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return Math.Round((_speed * _minutes) / 60, 2);
    }

    public override double Pace()
    {
        return Math.Round(60 / _speed, 2);
    }

    public override double Speed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} | Cycling : {Distance()} kilometers, {Speed()}kph, {Pace()}min per km";
    }
}