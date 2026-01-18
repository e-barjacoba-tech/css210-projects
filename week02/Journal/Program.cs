using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        bool boolean = true;
        PromptGenerator random = new PromptGenerator();
        Journal journal = new Journal();

        while(boolean == true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string menu = Console.ReadLine();
            int menuNumber = int.Parse(menu);
            
            if (menuNumber == 1)
            {
                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                entry._promptText = random.GetRandomPrompt();

                Console.WriteLine(entry._promptText);
                entry._entryText = Console.ReadLine();
                entry._date = date;
                
                journal.AddEntry(entry);
            }
            else if (menuNumber == 2)
            {
                journal.DisplayAll();
            }
            else if (menuNumber == 3)
            {
                journal.SaveToFile();
            }
            else if (menuNumber == 4)
            {
                journal.LoadFromFile();
            }
            else
            {
                boolean = false;
            }
        }


    }
}