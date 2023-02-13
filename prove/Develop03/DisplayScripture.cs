using System;
using System.IO;

public class DisplayScripture
{
    //runs the VerseCompilier from VerseHolder to put the scripture into a single string
    //then displays the compleated Verse
    public string UnderscoreFunc(string word) {
            var wordCount = word.Count();
            var blankWord = "";
            var singleWordCounter = 0;

            while (wordCount != singleWordCounter) {
                blankWord = blankWord + "_";
                singleWordCounter += 1;
            }
            return blankWord;
    }

    public string Display(string UpdatedVerse) {
        Random rnd = new Random();

        VerseHolder verse1 = new VerseHolder();
        var verseSplit = UpdatedVerse.Split(" "); //the current verse
        var totalCount = verseSplit.Count();

        int randomNumber = rnd.Next(totalCount);

        var replacedword = UnderscoreFunc(verseSplit[randomNumber]);
        verseSplit[randomNumber] =  replacedword; 
        
        
        
        string combinedString = string.Join( " ", verseSplit);

        var Verse = combinedString;
        var Heading = verse1._VerseHeading;
        Console.WriteLine(Heading + " " + Verse);
        Console.WriteLine();

        return combinedString;
    }

    public DisplayScripture(){}
}