public class ListingActivity : Activity
{
    private List<string> _promptList = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _numberOfAnwsers = 0;
    private string chosenPrompt;

    public ListingActivity(string activityType, string explanationMessage) : base(activityType, explanationMessage)
    {
        
    }

    private string RandomListingPrompt(){
        Random rnd = new Random();
        int promptNum = rnd.Next(3);
        chosenPrompt = _promptList[promptNum];
        return chosenPrompt;
    }

    public void Listing(int time){
        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadAnime(3);
        Console.WriteLine();
        RandomListingPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("  --- " + chosenPrompt + " ---  ");
        Console.Write("You may begin in: 5");

        //Count down
        int waitTime = 5;
        while (waitTime != 0){
            string waitString = waitTime.ToString();
            Thread.Sleep(1000);
            Console.Write("\b \b \b");
            waitTime -= 1;
            waitString = waitTime.ToString();
            Console.Write($"{waitString}");
        }
            Console.Write("\b \b \b");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        Console.WriteLine();
        while(DateTime.Now < futureTime){
            Console.Write(">");
            Console.ReadLine();
            _numberOfAnwsers += 1;
        }

        Console.WriteLine($"You listed {_numberOfAnwsers} items!");
    }
}