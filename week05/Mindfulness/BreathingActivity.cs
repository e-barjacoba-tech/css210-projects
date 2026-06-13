using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description ="You will learn how to relax by using and controlling your breathing";
        _duration = 60;
    }   
    
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Find a comfortable place where you can relax...\n");
        ShowSpinner(3);
        
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while(DateTime.Now < end)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
            Console.WriteLine();

        }

        DisplayEndingMessage();
        ShowSpinner(3);
        Console.Clear();
    }
}