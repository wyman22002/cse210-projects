using System;
using System.IO;
using Journal;

public class Entry
{
    string JournalDate = "";
    string DailyPrompt = "";
    string DailyAnswer = "";
    
    public string runGenerator() {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine();

        Entry entry = new Entry();
        string prompt = "";
        //string prompt1 = "";
    
        if (Journal.Program.Options.usePrompt == true) {
            PromptGenerator prompt1 = new PromptGenerator();
            //prompt1 = new PromptGenerator();
            prompt = prompt1.DisplayPrompt();
        }

        Console.Write("Enter in Text: ");
        string _input = Console.ReadLine();
        Console.WriteLine();

        entry.JournalDate = dateText;

        entry.DailyPrompt = prompt; 
        
        entry.DailyAnswer = _input;

        string fileName = "tempList.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            if (Journal.Program.Options.useDate == true) {
            outputFile.WriteLine(entry.JournalDate);
            }
            if (Journal.Program.Options.usePrompt == true) {
            outputFile.WriteLine(entry.DailyPrompt);
            }
            outputFile.WriteLine(entry.DailyAnswer);
            outputFile.WriteLine();
        }
        return prompt.ToString();
    }
    public Entry()
    {
    }
    
}