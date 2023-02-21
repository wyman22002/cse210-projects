public class Activity
{
    private string _introMessage = "";
    private string _explanationMessage = "";
    private int _time;
    private string _outroMessage = "";

    public Activity(string introMessage, string explanationMessage, string outroMessage)
    {
        _introMessage = introMessage;
        _explanationMessage = explanationMessage;
        _outroMessage = outroMessage;
    }

    public string GetIntroMessage() {
        return _introMessage;
    }
    public void SetIntroMessage(string introMessage) {
        _introMessage = introMessage;
    }

    public string GetExplanationMessage() {
        return _explanationMessage;
    }
    public void SetExplanationMessage(string explanationMessage) {
        _explanationMessage = explanationMessage;
    }

    public string GetOutroMessage() {
        return _outroMessage;
    }
    public void SetOutroMessage(string outroMessage) {
        _outroMessage = outroMessage;
    }


    public void DisplayIntroMessage() {
        Console.Clear();
        Console.Write("Welcome to the ");
        Console.WriteLine(_introMessage, ".");
        Console.WriteLine();
        Console.WriteLine(_explanationMessage);

    }
    public void DisplayExplanation() {
        Console.WriteLine(_explanationMessage);
    }
    public void DisplayOutroMessage() {
        Console.WriteLine(_outroMessage);
        Thread.Sleep(5000);
    }
    public int Length() {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string userTime = Console.ReadLine();
        _time = int.Parse(userTime);
        return _time;
    }
}