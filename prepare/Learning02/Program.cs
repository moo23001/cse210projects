using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web Programmer";
        job1._company = "Amazon";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "BackEnd Programmer";
        job2._company = "IBM";
        job2._startYear = 2017;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Fulano De Tal";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }

    
}