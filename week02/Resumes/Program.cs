using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); 
        //it is important to remember the () after using the new Class constructor
        job1._jobTitle = "Missionary";
        job1._company = "The Church Of Jesus Christ Of Latter Day Saints";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Missionary Training Center";
        job2._jobTitle = "In-Field Mentor";
        job2._startYear = 2025;
        job2._endYear = 2027;

        Resume myResume = new Resume();
        myResume._name = "Ezequiel Matias Barjacoba";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();


    }
}