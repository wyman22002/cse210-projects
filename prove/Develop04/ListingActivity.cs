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

    public ListingActivity(string activityType, string explanationMessage) : base(activityType, explanationMessage)
    {
        
    }
}