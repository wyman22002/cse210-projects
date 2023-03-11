public class DisplaySimpleRecords : RecordEvent
{
    public override void Displayer(){
        string filename = "tempFile.txt";
        int lineNum = GetLineNum();
        int displayNum = GetDisplayNum();

        string line = File.ReadLines(filename).Skip(lineNum).Take(1).First();

        string[] parts = line.Split("|");

        //GoalType | Name | Description | BasePoints | Compleated
        string goalName = parts[1];
        string completed = parts[4];

        if (completed != "true"){
            Console.WriteLine($"{displayNum.ToString()}. {goalName}");
            SetDisplayNum(displayNum += 1);
            UncompleatedGoals.Add(lineNum);
        }
    }
}

public class DisplayEternalRecords : RecordEvent
{
    public override void Displayer(){
        string filename = "tempFile.txt";
        int lineNum = GetLineNum();
        int displayNum = GetDisplayNum();

        string line = File.ReadLines(filename).Skip(lineNum).Take(1).First();
        
        string[] parts = line.Split("|");
        
        //GoalType | Name | Description | BasePoints
        string goalName = parts[1];
        string basePoints = parts[3];
            
        Console.WriteLine($"{displayNum.ToString()}. {goalName}");
        SetDisplayNum(displayNum += 1);
        UncompleatedGoals.Add(lineNum);

    }
}

public class DisplayChecklistRecords : RecordEvent
{
    public override void Displayer(){
        string filename = "tempFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int lineNum = GetLineNum();
        int displayNum = GetDisplayNum();

        string line = File.ReadLines(filename).Skip(lineNum).Take(1).First();
        
        string[] parts = line.Split("|");

        //GoalType | Name | Description | BasePoints | BonusPoints | TotalNum | CurrentNum
        string goalName = parts[1];
        string totalNum = parts[5];
        string currentNum = parts[6];
            
        if(currentNum != totalNum){
            Console.WriteLine($"{displayNum.ToString()}. {goalName}");
            SetDisplayNum(displayNum += 1);
            UncompleatedGoals.Add(lineNum);
        }
    }
}
public class SimpleRecord : RecordEvent
{
    public override void EventRecorder(){
        //SimpleGoal | Name | Description | BasePoints | Compleated
        string filename = "tempFile.txt";
        string line = GetCompleatedLine();
        string[] parts = line.Split("|");

        string goalName = parts[1];
        string description = parts[2];
        string basePoints = parts[3];
        string completed = parts[4];

        int oldLine = GetOldLine();
        string newLine = $"SimpleGoal|{goalName}|{description}|{basePoints}|true";

        int pointsB = int.Parse(basePoints);
        string PointsA = File.ReadLines(filename).Take(1).First();
        int totalPoints = int.Parse(PointsA);
        int allPoints = pointsB + totalPoints;
        Console.WriteLine($"You eared {pointsB} points!");
        lineChanger(allPoints.ToString(), filename, 0);
        lineChanger(newLine, filename, oldLine);

        //Write over the lines in the files with the "newLine" and the "allPoints"
        static void lineChanger(string newText, string filename, int pastLine)
        {
             string[] arrLine = File.ReadAllLines(filename);
             arrLine[pastLine] = newText;
             File.WriteAllLines(filename, arrLine);
        }

    }
}

public class EternalRecord : RecordEvent
{
    public override void EventRecorder(){
        //EternalGoal | Name | Description | BasePoints
        string filename = "tempFile.txt";
        string line = GetCompleatedLine();
        string[] parts = line.Split("|");

        string goalName = parts[1];
        string description = parts[2];
        string basePoints = parts[3];

        int oldLine = GetOldLine();
        string newLine = $"EternalGoal|{goalName}|{description}|{basePoints}";

        int pointsB = int.Parse(basePoints);
        string PointsA = File.ReadLines(filename).Take(1).First();
        int totalPoints = int.Parse(PointsA);
        int allPoints = pointsB + totalPoints;
        Console.WriteLine($"You eared {pointsB} points!");
        lineChanger(allPoints.ToString(), filename, 0);
        lineChanger(newLine, filename, oldLine);

        //Write over the lines in the files with the "newLine" and the "allPoints"
        static void lineChanger(string newText, string filename, int pastLine)
        {
             string[] arrLine = File.ReadAllLines(filename);
             arrLine[pastLine] = newText;
             File.WriteAllLines(filename, arrLine);
        }
    }

}

public class ChecklistRecord : RecordEvent
{
    public override void EventRecorder(){
        //ChecklistGoal | Name | Description | BasePoints | BonusPoints | TotalNum | CurrentNum
        string filename = "tempFile.txt";
        string line = GetCompleatedLine();
        string[] parts = line.Split("|");

        string goalName = parts[1];
        string description = parts[2];
        string basePoints = parts[3];
        string bonusPoints = parts[4];
        string totalNum = parts[5];
        string currentNum = parts[6];

        int total = int.Parse(totalNum);
        int overrideNum = int.Parse(currentNum);
        overrideNum += 1;
        //string newNum = overrideNum.ToString();


        int oldLine = GetOldLine();
        string newLine = $"ChecklistGoal|{goalName}|{description}|{basePoints}|{bonusPoints}|{totalNum}|{overrideNum.ToString()}";

        string PointsA = File.ReadLines(filename).Take(1).First();
        int pointsB = int.Parse(basePoints);
        int pointsC = int.Parse(bonusPoints);
        int totalPoints = int.Parse(PointsA);
        int allPoints = pointsB + totalPoints;
        int plusBonus = pointsB + pointsC;
        int allPointsPlus = plusBonus + totalPoints;


        if (overrideNum != total){
            Console.WriteLine($"You eared {pointsB} points!");
            lineChanger(allPoints.ToString(), filename, 0);
        } else{
            Console.WriteLine($"You eared {pointsB} points!");
            Console.WriteLine($"You eared a bonus of {pointsC} points!");
            lineChanger(allPointsPlus.ToString(), filename, 0);
        }

        lineChanger(newLine, filename, oldLine);

        //Write over the lines in the files with the "newLine" and the "allPoints"
        static void lineChanger(string newText, string filename, int pastLine)
        {
             string[] arrLine = File.ReadAllLines(filename);
             arrLine[pastLine] = newText;
             File.WriteAllLines(filename, arrLine);
        }
    }

}
