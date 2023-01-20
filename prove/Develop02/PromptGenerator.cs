using System;
public class PromptGenerator
{
    public string DisplayPromt() {
        string[] _listOfPromts = {"What was a place you went to today?", "Who was someone you saw?",
        "What was your faviorte meal today?", "Where is one place you would like to go?",
        "Who do you look up to?", "What kind of hobbies do you enjoy?"};


        Random rnd = new Random();
        Console.WriteLine("Prechance");

        int chance = rnd.Next(0,5);
        Console.WriteLine(_listOfPromts[chance]);
        return _listOfPromts[chance];
    }

    public PromptGenerator()
    {
    }

}