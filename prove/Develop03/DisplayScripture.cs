using System;
using System.IO;

public class DisplayScripture
{
    //runs the VerseCompilier from VerseHolder to put the scripture into a single string
    //then displays the compleated Verse
    public void Display() {

        RandomWordSelector random1 = new RandomWordSelector();
        var list = random1.rndNumList;
        var words = random1.ReplaceWords(list);


        VerseHolder verse1 = new VerseHolder();
        var verseSplit = verse1._Verse.Split(" ");
        var totalCount = verseSplit.Count();

        
        foreach (int word in words) {
            int index = words.FindIndex(ind => ind.Equals("123"));
            if (index > -1) {
                words[index] =  "def";
            }


            var blankWord = "";
            var singleWordCounter = 0;
            while (wordCount != singleWordCounter) {
                blankWord = blankWord + "_";
                singleWordCounter += 1;
            }
        }

        var Verse = verse1._Verse;
        var Heading = verse1._VerseHeading;
        Console.WriteLine(Heading + " " + Verse);
        Console.WriteLine();
    }

    public DisplayScripture(){}
}