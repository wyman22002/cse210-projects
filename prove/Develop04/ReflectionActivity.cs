public class ReflectionActivity : Activity
{
    private List<string> _promptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectionStatments = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string chosenPrompt = "";
    private string chosenStatment = "";

    public ReflectionActivity(string activityType, string explanationMessage) : base(activityType, explanationMessage)
    {
        
    }

    private string GetRandomPrompt(){
        Random rnd = new Random();
        int promptNum = rnd.Next(3);
        chosenPrompt = _promptList[promptNum];
        return chosenPrompt;
    }
    private string GetRandomStatment(){
        Random rnd = new Random();
        int statmentNum = rnd.Next(8);
        chosenStatment = _reflectionStatments[statmentNum];

        return chosenStatment;
    }

    public void DisplayPrompt(){
        Console.WriteLine("Get ready...");
        LoadAnime(2);
        GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine("  --- " + chosenPrompt + " ---  ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayStatment(int _time){
        Console.Clear();
        while (_time > 0){
            if (_time < 10 && _time > 0) {
                Console.WriteLine(_time);
                GetRandomStatment();
                Console.WriteLine(">" + chosenStatment);
                LoadAnime(_time);
                _time -= _time;

            } else {
                GetRandomStatment();
                Console.WriteLine(">" + chosenStatment);
                LoadAnime(10);
                _time -= 10;  
            }
            Console.WriteLine();
        }
    }
}