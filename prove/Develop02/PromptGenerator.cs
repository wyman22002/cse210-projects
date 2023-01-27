using System;
public class PromptGenerator
{
    public string DisplayPrompt() {
        string[] _listOfPrompts = {"What was a place you went to today?", "Who was someone you saw?",
        "What was your faviorte meal today?", "Where is one place you would like to go?",
        "Who do you look up to?", "What kind of hobbies do you enjoy?"};


        Random rnd = new Random();

        int chance = rnd.Next(0,5);
        Console.WriteLine(_listOfPrompts[chance]);
        return _listOfPrompts[chance];
    }

    public PromptGenerator()
    {
    }

}