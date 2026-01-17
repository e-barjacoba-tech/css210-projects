using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? (1-100) ");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100); 

        string guess = "";
        int magicGuess = 0;

        while (magicNumber != magicGuess)
        {
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            magicGuess = int.Parse(guess);

            if (magicNumber == magicGuess)
            {
                Console.WriteLine("You're right!");
            }
            else if (magicNumber < magicGuess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > magicGuess)
            {
                Console.WriteLine("Higher");
            }
        }
        
    }
}