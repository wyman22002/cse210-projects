using System;
using System.IO;

class Program
{


    static void Main(string[] args)
    {
        VerseHolder holder = new VerseHolder();

        var UpdatedVerse = holder._Verse;

        string UserInput = "";
        int counter = 0;
        while (UserInput != "quit") {
            var compilier = holder.VerseCompilier();
            var original = holder._VerseOriginal.Split(" ");
            var total = original.Count();

            if (counter == 0) {
                Console.WriteLine(compilier);
                
            } else {
            DisplayScripture display1 = new DisplayScripture();
            UpdatedVerse = display1.Display(UpdatedVerse);
            }

            counter += 1;

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            UserInput = Console.ReadLine();
            Console.Clear();
        }   
    }
}