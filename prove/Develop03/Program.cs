using System;
using System.IO;

class Program
{


    static void Main(string[] args)
    {
        List<int> NumberList = new List<int>();

        string UserInput = "";
        int counter = 0;
        while (UserInput != "quit") {
            VerseHolder holder = new VerseHolder();
            var compilier = holder.VerseCompilier();
            var original = holder._VerseOriginal.Split(" ");
            var total = original.Count();

            if (counter == 0) {
                Console.WriteLine(compilier);
            } else {
            DisplayScripture display1 = new DisplayScripture();
            display1.Display();
            }

            counter += 1;

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            UserInput = Console.ReadLine();
            Console.Clear();
        }   
    }
}