using System;
using System.Collections.Generic;
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
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        Console.ForegroundColor = ConsoleColor.Red;
        /*
        while(loadTime > 0){
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("!");
            Thread.Sleep(500);
            Console.Write("\b \b");
            loadTime -= 1;
        }
        */
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(loadTime);

        int i = 0;

        while (DateTime.Now < endTime) {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count) {
                i = 0;
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
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