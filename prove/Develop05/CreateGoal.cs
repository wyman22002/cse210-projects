using System.IO;
public abstract class CreateGoal
{
    private string _goalName = "";
    private string _description = "";
    private int _basePoints;
    private int _numOfTimes;
    private int _bonus;

    public CreateGoal(){

    }
    
    public string GetName() {
        return _goalName;
    }
    public void SetName(string goalName) {
        _goalName = goalName;
    }

    public string GetDescription() {
        return _description;
    }
    public void SetDescription(string description) {
        _description = description;
    }

    public int GetPoints() {
        return _basePoints;
    }
    public void SetPoints(int basePoints) {
        _basePoints = basePoints;
    }

    public int GetNumOfTimes() {
        return _numOfTimes;
    }
    public void SetNumOfTimes(int numOfTimes) {
        _numOfTimes = numOfTimes;
    }
    public int GetBonus() {
        return _bonus;
    }
    public void SetBonus(int bonus) {
        _bonus = bonus;
    }

    public abstract void GoalCreation();

    public virtual void WriteFile() {
        string fileName = "tempFile.txt";

        //SimpleGoal | Name | Description | BasePoints | Compleated
        //EternalGoal | Name | Description | BasePoints
        //ChecklistGoal | Name | Description | BasePoints | BonusPoints | TotalNum | CurrentNum

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"SimpleGoal|{_goalName}|{_description}|{_basePoints}|false");

        }
    }

    
}
