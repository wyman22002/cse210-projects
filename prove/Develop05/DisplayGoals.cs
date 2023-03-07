public class DisplaySimple : ListGoal
{
    public override void DisplayGoal(){
        int goalNum = 1;
        string filename = "tempFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string goalName = parts[0];
            string description = parts[1];
            string basePoints = parts[2];
            
            Console.WriteLine($"{goalNum.ToString()}. [ ] {goalName} ({description})");
        }
    }

}