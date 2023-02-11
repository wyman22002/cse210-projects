using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string UserInput;

        while (UserInput != "quit") {
            DisplayScripture display1 = new DisplayScripture();
            display1.Display();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            UserInput = Console.ReadLine();

                if (Console.ReadKey().Key == ConsoleKey.Enter) {
                    RandomWordSelector random1 = new RandomWordSelector();
                    random1.ReplaceWords();
                } else {
                
                }
        }   
    }
}