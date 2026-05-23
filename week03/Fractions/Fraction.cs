using System;
using System.IO.Pipelines;

public class Fraction
{
    //attributes
    private int _top;
    private int _bottom;

    //contructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //methods
    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }

    // The assingment asks for getters and setters
    // I found them useless actually, but I'm gonna make them for the sake of learning 

    //getters 
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    //setters
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
}