using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        int i = 1;

        while(i == 1)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice form the menu: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                CreateGoal();
            }
            else if (answer == 2)
            {
                ListGoalDetails();
            }
            else if (answer == 3)
            {
                SaveGoals();
            }
            else if (answer ==  4)
            {
                LoadGoals();
            }
            else if (answer == 5)
            {
                RecordEvent();
            }
            else if (answer == 6)
            {
                i++;
            }
            else
            {
                Console.WriteLine("Please, write a valid response");
            }

        }

    }

    public void DisplayPlayerInfo()
    {
        
    }

    public void ListGoalNames()
    {
        int i = 0;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"  {i}. {goal}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goal are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        
        Console.Write("Which type of goal would you like to create? ");
        int answerGoal = int.Parse(Console.ReadLine());

        string name = "";
        string description = "";
        int points = 0;

        if (answerGoal == 1)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal (name, description, points, false);
            _goals.Add(simpleGoal);

        }
        else if (answerGoal == 2)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal (name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (answerGoal == 3)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal (name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals()
    {
        string filename = "goals.txt";
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine();
        }
    }
    
    public void LoadGoals()
    {
        
    }
}
