public class DisplaySimple : ListGoal
{
    public override void DisplayGoal(){
        string filename = "tempFile.txt";
        int goalNum = GetGoalNum();

        string line = File.ReadLines(filename).Skip(goalNum).Take(1).First();

        string[] parts = line.Split("|");

        //GoalType | Name | Description | BasePoints | Compleated
        string goalName = parts[1];
        string description = parts[2];
        string basePoints = parts[3];
        string completed = parts[4];
        string checkMark = " ";
        if (completed == "true"){
            checkMark = "X";
        }
        
        Console.WriteLine($"{goalNum.ToString()}. [{checkMark}] {goalName} ({description})");
    }
}

public class DisplayEternal : ListGoal
{
    public override void DisplayGoal(){
        string filename = "tempFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int goalNum = GetGoalNum();

        string line = File.ReadLines(filename).Skip(goalNum).Take(1).First();
        
            string[] parts = line.Split("|");

            //GoalType | Name | Description | BasePoints
            string goalName = parts[1];
            string description = parts[2];
            string basePoints = parts[3];
            
            Console.WriteLine($"{goalNum.ToString()}. [ ] {goalName} ({description})");
        
    }
}

public class DisplayChecklist : ListGoal
{
    public override void DisplayGoal(){
        string filename = "tempFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int goalNum = GetGoalNum();

        string line = File.ReadLines(filename).Skip(goalNum).Take(1).First();
        
            string[] parts = line.Split("|");

            //GoalType | Name | Description | BasePoints | BonusPoints | TotalNum | CurrentNum
            string goalName = parts[1];
            string description = parts[2];
            string basePoints = parts[3];
            string totalNum = parts[5];
            string currentNum = parts[6];
            
            string checkMark = " ";
            if (totalNum == currentNum){
                checkMark = "X";
            }

            Console.WriteLine($"{goalNum.ToString()}. [{checkMark}] {goalName} ({description}) -- Currently completed: {currentNum}/{totalNum}");
        
    }
}