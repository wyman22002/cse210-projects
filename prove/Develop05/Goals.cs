using System.IO;

public class SimpleGoal : CreateGoal
{
    public override void GoalCreation(){
                
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetName(name);

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        SetDescription(description);

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        int basePoints = int.Parse(points);
        SetPoints(basePoints);

        //GoalType | Name | Description | BasePoints | Compleated
        WriteFile();
    }
}


public class EternalGoal : CreateGoal
{
    public override void GoalCreation(){
                
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        int basePoints = int.Parse(points);
        SetPoints(basePoints);

        WriteFile();
    }
    public override void WriteFile()
    {
        string fileName = "tempFile.txt";

        string name = GetName();
        string description = GetDescription();
        int basePoints = GetPoints();

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"EternalGoal|{name}|{description}|{basePoints}");

        }
    }
}


public class ChecklistGoal : CreateGoal
{
    public override void GoalCreation(){
                
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        int basePoints = int.Parse(points);
        SetPoints(basePoints);

        Console.Write("how many times does this goal need to be accomplished for a bonus? ");
        string numOfTimes = Console.ReadLine();
        int times = int.Parse(numOfTimes);
        SetNumOfTimes(times);

        Console.Write("What is the bonus for accomplisting it that many times? ");
        string pointPlus = Console.ReadLine();
        int extraPoints = int.Parse(pointPlus);
        SetBonus(extraPoints);

        WriteFile();
    }
    public override void WriteFile()
    {
        string fileName = "tempFile.txt";

        string name = GetName();
        string description = GetDescription();
        int basePoints = GetPoints();
        int times = GetNumOfTimes();
        int bonus = GetBonus();

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"SimpleGoal|{name}|{description}|{basePoints}|{bonus}|{times}|0");

        }
    }
}