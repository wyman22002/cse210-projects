using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Maria Hill", "Calculas");
        Console.WriteLine(assignment1.GetSummery());

        MathAssignment assignment2 = new MathAssignment("Ash Waterson", "Addition", "6.5", "1-9");
        Console.WriteLine(assignment2.GetSummery());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Dave Smith", "Civil War", "Who was right?");
        Console.WriteLine(assignment3.GetSummery());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}