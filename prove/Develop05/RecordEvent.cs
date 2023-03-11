public class RecordEvent
{
    public static int _lineNum = 1;
    public static int _displayNum = 1;
    public static string _compleatedLine = "";
    public static int _oldLine;

    public int GetLineNum() {
        return _lineNum;
    }
    public void SetLineNum(int lineNum) {
        _lineNum = lineNum;
    }

    public int GetDisplayNum() {
        return _displayNum;
    }
    public void SetDisplayNum(int displayNum) {
        _displayNum = displayNum;
    }

    public string GetCompleatedLine() {
        return _compleatedLine;
    }
    public void SetCompleatedLine(string compleatedLine) {
        _compleatedLine = compleatedLine;
    }
    public int GetOldLine() {
        return _oldLine;
    }
    public void SetOldLine(int oldLine) {
        _oldLine = oldLine;
    }
    public static List<int> UncompleatedGoals = new List<int>();



    public void Recorder(){
                
        string filename = "tempFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        DisplaySimpleRecords record1 = new DisplaySimpleRecords();
        DisplayEternalRecords record2 = new DisplayEternalRecords();
        DisplayChecklistRecords record3 = new DisplayChecklistRecords();

        Console.WriteLine("The goals are:");
        foreach (string line in lines.Skip(1))
        {
            int lineNum = GetLineNum();
            string[] parts = line.Split("|");

            //GoalType | Name | Description | BasePoints | Compleated
            string GoalType = parts[0];

            if (GoalType == "SimpleGoal"){
                record1.Displayer();
            }
            else if (GoalType == "EternalGoal"){
                record2.Displayer();
            }
            else if (GoalType == "ChecklistGoal"){
                record3.Displayer();
            }
            SetLineNum(lineNum + 1);

        }

        SetLineNum(1);
        SetDisplayNum(1);

        Console.Write("What goal did you accomplish? ");
        string UserAnwser = Console.ReadLine();
        int ListLine = int.Parse(UserAnwser);
        ListLine -= 1;
        int goal = UncompleatedGoals[ListLine];
        string CompleatedTask = File.ReadLines(filename).Skip(goal).Take(1).First();
        SetCompleatedLine(CompleatedTask);
        int fileLine = UncompleatedGoals[ListLine];
        SetOldLine(fileLine);//Problem is here, we are getting the line number from the user but when a task is compleate and it shows less the USER input is used for location not its place in the file

        string[] lineParts = CompleatedTask.Split("|");
        string LineType = lineParts[0];

        if (LineType == "SimpleGoal"){
            SimpleRecord simple = new SimpleRecord();
            simple.EventRecorder();
        }
        else if (LineType == "EternalGoal"){
            EternalRecord eternal = new EternalRecord();
            eternal.EventRecorder();
        }
        else if (LineType == "ChecklistGoal"){
            ChecklistRecord checklist = new ChecklistRecord();
            checklist.EventRecorder();
        }
        UncompleatedGoals.Clear();
    }
    public virtual void Displayer(){}
    public virtual void EventRecorder(){}

}