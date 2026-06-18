using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToString("yyyy MMM dd"); 

        List<Activity> activities = new List<Activity>();

        Running running = new Running(date, 35, 5);
        activities.Add(running);

        Swimming swimming = new Swimming(date, 20, 13);
        activities.Add(swimming);

        Cycling cycling = new Cycling(date, 80, 15.3);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}