public class Activity
{
    private string _activityType = "";
    private string _explanationMessage = "";
    private int _time;

    public Activity(string activityType, string explanationMessage)
    {
        _activityType = activityType;
        _explanationMessage = explanationMessage;
    }

    public string GetActivityType() {
        return _activityType;
    }
    public void SetActivityType(string activityType) {
        _activityType = activityType;
    }

    public string GetExplanationMessage() {
        return _explanationMessage;
    }
    public void SetExplanationMessage(string explanationMessage) {
        _explanationMessage = explanationMessage;
    }

    public void LoadAnime(int loadTime)
    {
        while(loadTime > 0){
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("!");
            Thread.Sleep(500);
            Console.Write("\b \b");
            loadTime -= 1;
        }
    }

    public void DisplayIntroMessage() {
        Console.Clear();
        Console.Write("Welcome to the ");
        Console.WriteLine(_activityType + ".");
        Console.WriteLine();
        Console.WriteLine(_explanationMessage);
    }
    public void DisplayOutroMessage() {
        Console.WriteLine("Well done!!");
        LoadAnime(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_activityType}");
        LoadAnime(2);
    }
    public int Length() {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string userTime = Console.ReadLine();
        _time = int.Parse(userTime);
        return _time;
    }
}