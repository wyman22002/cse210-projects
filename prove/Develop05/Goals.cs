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

        WriteFile();
    }
}

/*
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

    }
}
*/