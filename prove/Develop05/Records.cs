/*
public class SimpleRecord : RecordEvent
{
    public override void EventRecorder(){
        string filename = "tempFile.txt";

        string line = File.ReadLines(filename).Skip(goalNum).Take(1).First();

        string[] parts = line.Split("|");

        //GoalType | Name | Description | BasePoints | Compleated
        string goalName = parts[1];
        string basePoints = parts[3];
        string completed = parts[4];

        if (completed == "true"){
        } else{
            Console.WriteLine($"{goalNum.ToString()}. {goalName}");

        }

        
    }
}

public class EternalRecord : RecordEvent
{
    public override void EventRecorder(){
        string filename = "tempFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");

            //GoalType | Name | Description | BasePoints
            string goalName = parts[1];
            string basePoints = parts[3];
            
            Console.WriteLine($"{goalNum.ToString()}. {goalName}");
        }
    }

}

public class ChecklistRecord : RecordEvent
{
    public override void EventRecorder(){
        string filename = "tempFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");

            //GoalType | Name | Description | BasePoints | BonusPoints | TotalNum | CurrentNum
            string goalName = parts[1];
            string basePoints = parts[3];
            string totalNum = parts[5];
            string currentNum = parts[6];
            
            Console.WriteLine($"{goalNum.ToString()}. {goalName}");
        }
    }

}
*/