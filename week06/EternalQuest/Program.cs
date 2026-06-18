using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is the Eternal Quest Project.");
        
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}