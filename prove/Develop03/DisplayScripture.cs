using System;

public class DisplayScripture
{
    //runs the VerseCompilier from VerseHolder to put the scripture into a single string
    //then displays the compleated Verse
    public void Display() {
    VerseHolder holder1 = new VerseHolder();
    holder1.VerseCompilier();
    }

    public DisplayScripture(){}
}