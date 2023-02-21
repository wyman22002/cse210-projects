using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity("Test for introMessage", "Test for explanationMessage", "Test for OutroMessage");
        activity1.DisplayIntroMessage();
        activity1.DisplayExplanation();
        activity1.DisplayOutroMessage();
    }
}