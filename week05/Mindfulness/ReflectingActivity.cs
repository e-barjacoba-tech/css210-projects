using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _question = new List<string>();

    public ReflectingActivity()
    {
        //variables
        _name = "Reflecting Activity";
        _description = "You will reflect back in your life to look for evidences of who you are today";
        _duration = 60;
        //questions (from the activity page)
        _question.Add("Why was this experience meaningful to you?");
        _question.Add("What could you learn from this experience that applies to other situations?");
        _question.Add("What did you learn about yourself and/or God through this experience?");
        _question.Add("How can you keep this experience in mind in the future?");
        _question.Add("What could you learn from this experience that applies to other situations?");
        //prompts (from the activity page)
        _prompts.Add("Think about a time when you did something difficult");
        _prompts.Add("Think about a time when you felt joy");
        _prompts.Add("Think about a time when you helped someone in need");
        _prompts.Add("Think about a time when you felt the Spirit");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready\n");
        ShowSpinner(3);

        Console.WriteLine("Consider the following prompt ->\n");
        DisplayPrompt();
        Console.WriteLine("You may start in...");
        ShowCountdown(30);

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while(DateTime.Now < end)
        {
            DisplayQuestions();
            Console.WriteLine(">");
            Console.ReadLine();
        }

        Console.WriteLine("Well done!");
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

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_question.Count);
        string randomQuestion = _question[index];
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"---{prompt}---"); 
    }

    public void DisplayQuestions()
    {
        string question = GetRandomPrompt();
        Console.WriteLine($"---{question}---");
    }

}