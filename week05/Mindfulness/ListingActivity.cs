using System;
using System.Xml.Serialization;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "You will learn how to take note of all the good things in your life.";
        _duration = 60;
        //Adding prompts to the list
        _prompts.Add("How did you feel the Holy Ghost today?");
        _prompts.Add("What nice things have you done for yourself today?");
        _prompts.Add("What nice things have you done for others today?");
        _prompts.Add("What things did you learn today by making mistakes?");
        _prompts.Add("What things would a friend say to you if he knew you were in this situation?");
        _prompts.Add("When did you feel joy?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready\n");
        ShowSpinner(3);

        string prompt = "List as many responses you can to the following prompt:\n";
        prompt += $"---{GetRandomPrompt()}---\n";
        prompt += "You may begin in...";
        Console.WriteLine(prompt);
        ShowCountdown(5);

        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} responses!");

        DisplayEndingMessage();
        ShowSpinner(3);
        Console.Clear();
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }

    public List<string> GetListFromUser()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        List<string> responses = new List<string>();

        while(DateTime.Now < end)
        {
            Console.Write("<");
            responses.Add(Console.ReadLine());
        }

        return responses;
    }
}