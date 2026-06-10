using System;

class Program
{
    static void Main(string[] args)
    {
        //using the base class
        Assingment homework = new Assingment("Ezequiel Barjacoba", "History");
        Console.WriteLine(homework.GetSummary());

        //using MathAssingment 
        MathAssingment mathHomework = new MathAssingment("Rodrigo", "Exponentiation", "4.7", "9-15");
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());

        //using WritingAssignment
        WritingAssignment researchHomework = new WritingAssignment("Luciana", "Human Behaviour", "CBT Therapy Concepts");
        Console.WriteLine(researchHomework.GetSummary());
        Console.WriteLine(researchHomework.GetWritingInformation());
    }
}