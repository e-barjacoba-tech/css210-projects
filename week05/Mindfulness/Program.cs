using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;

        while(i == 0)
        {
            Console.WriteLine("Choose an activity");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit\n");
            int answer = int.Parse(Console.ReadLine());
            
            if (answer == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (answer == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (answer == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (answer == 4)
            {
                i++;
            }
            else
            {
                Console.WriteLine("Please, write a valid response");
            }
        }
    }
}