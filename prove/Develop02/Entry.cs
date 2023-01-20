using System;
using System.IO;

public class Entry
{
    string JournalDate = "";
    string DailyPrompt = "";
    string DailyAnswer = "";

    public string runGenerator() {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entry entry = new Entry();

        PromptGenerator promt1 = new PromptGenerator();


        string promt = promt1.DisplayPromt();
        Console.Write("Enter in Text: ");
        string _input = Console.ReadLine();

        entry.JournalDate = dateText;
        entry.DailyPrompt = promt;
        entry.DailyAnswer = _input;


        string fileName = "tempList.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
           outputFile.WriteLine(entry.JournalDate);
           outputFile.WriteLine(entry.DailyPrompt);
           outputFile.WriteLine(entry.DailyAnswer);
           outputFile.WriteLine();
        }


        return promt1.ToString();
    }
    public Entry()
    {
    }
    
}