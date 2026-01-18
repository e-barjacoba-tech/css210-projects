using System;
using System.Collections.Generic; 

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What's the bravest thing that you did today?");
        _prompts.Add("Who made you feel heard and important today?");
        _prompts.Add("Tell me something your personal challenges taught you");
        _prompts.Add("How has the Lord given you answers to your prayers today?");
        _prompts.Add("Top 3 moments of your day");
        _prompts.Add("What is something you're looking forward to do tomorrow?");
        _prompts.Add("What ideas you might put into practice in the future?");
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count-1);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
}