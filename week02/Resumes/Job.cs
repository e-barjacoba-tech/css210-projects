using System;

public class Job
{
    public string _jobTitle; 
    //always remember to write "public" before initializing an attribute
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}