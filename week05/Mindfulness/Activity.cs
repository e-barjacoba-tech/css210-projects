using System;
using System.Runtime.CompilerServices;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name =  "Default";
        _description = "Unknown activity";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.\n");
        Console.WriteLine($"We will {_description}");
        Console.WriteLine("How long would you like it to last (in seconds)?");
        _duration = int.Parse(Console.ReadLine());

    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thank you so much for completing the {_name} activity for the last {_duration}I \n");
        Console.WriteLine($"We hope to see you soon!");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> characters = new List<string>();
        characters.Add("|");
        characters.Add("/");
        characters.Add("-");
        characters.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime ending = startTime.AddSeconds(seconds);

        int count = 0;

        while (DateTime.Now < ending)
        {
            //I used \r because it runs cleaner 
            string oneCharacter = characters[count];
            Console.Write("\r" + oneCharacter);
            Thread.Sleep(1000);

            count++;

            if (count >= characters.Count)
            {
                count = 0;
            }
        }

        //Now, at the end of the loop, the animation is gone
        Console.Write("\r ");
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            //This was my first approach

            // Console.Write(i);
            // Thread.Sleep(1000);
            // int digitCount = i.ToString().Length;
            // if (digitCount == 1)
            // {
            //     Console.Write("\b \b");
            // }
            // else if (digitCount == 2)
            // {
            //     Console.Write("\b \b\b \b");
            // }
            // else if (digitCount == 3)
            // {
            //     Console.Write("\b \b\b \b\b \b");
            // }

            //Then I discovered, again, the \r
            
            Console.Write("\r" + i + " "); 
            //returns to the beginning of the string, replaces the number, and erases any other space left
            Thread.Sleep(1000);
        }
    }
}