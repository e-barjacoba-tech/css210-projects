using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter = "A";

        if (gradeNumber >= 90)
        {
            Console.Write($"You got an {letter}! ");
        }
        else if (gradeNumber >= 80 && gradeNumber < 90)
        {
           letter = "B"; 
           Console.Write($"You got a {letter}! "); 
        }
        else if (gradeNumber >= 70 && gradeNumber < 80)
        {
           letter = "C";  
           Console.Write($"You got a {letter}... "); 
        }
        else if (gradeNumber >= 60 && gradeNumber < 70)
        {
           letter = "D"; 
           Console.Write($"You got a {letter}... "); 
        }
        else if (gradeNumber < 60)
        {
           letter = "F"; 
           Console.Write($"... you got an {letter}... "); 
        }
        
        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed the class :)");
        }
        else
        {
            Console.WriteLine("Don't give up! Try again next semester");  
        }
    }
}