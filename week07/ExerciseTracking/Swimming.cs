using System;
using System.Reflection.Metadata.Ecma335;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 100;
    }

    public override double Pace()
    {
        return Math.Round((Distance() / _minutes) * 60, 2);
    }

    public override double Speed()
    {
        return Math.Round(_minutes / Distance(), 2);
    }

    public override string GetSummary()
    {
        return $"{_date} | Swimming : {Distance()} meters, {Speed()}kph, {Pace()}min per km";
    }
}