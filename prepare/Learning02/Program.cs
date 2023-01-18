using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Nintendo";
        job1._jobTitle = "Localizer";
        job1._startYear = 2025;
        job1._endYear = 2029;



        job2._company = "Capcom";
        job2._jobTitle = "Level Desinger";
        job2._startYear = 2029;
        job2._endYear = 2031;


        Resume resume1 = new Resume();
        resume1._name = "Tanner Wyman";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.DisplayResume();
    }
}