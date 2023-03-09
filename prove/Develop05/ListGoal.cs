public class ListGoal
{
    public static int _goalNum = 1;

    public int GetBonus() {
        return _goalNum;
    }
    public void SetBonus(int goalNum) {
        _goalNum = goalNum;
    }
    
    public void RunThoughList(){
        
        string filename = "tempFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int lineNum = 1;

        DisplaySimple goal1 = new DisplaySimple();
        DisplayEternal goal2 = new DisplayEternal();
        DisplayChecklist goal3 = new DisplayChecklist();

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");

            //GoalType | Name | Description | BasePoints | Compleated
            string GoalType = parts[0];

            if (GoalType == "SimpleGoal"){
                goal1.DisplayGoal();
            }
            else if (GoalType == "EternalGoal"){
                goal2.DisplayGoal();
            }
            else if (GoalType == "ChecklistGoal"){
                goal3.DisplayGoal();
            }
            lineNum ++;
            SetBonus(lineNum); 
        }
    }
    public virtual void DisplayGoal(){}
}