using System;
using System.IO; 

namespace Journal
{
public class Program
{

    static public class Options
    {
    static public bool usePrompt = true;
    static public bool useDate = true;
    }

    static void Main(string[] args)
    {

        string UserInput = "0";

        while (UserInput != "5") 
        {
            Console.WriteLine("Welcome to the Journal Machine.");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.End Program");
            Console.WriteLine("6.Help");
            Console.WriteLine("7.Options");
            Console.Write("SELECT YOUR OPTION: ");
            UserInput = Console.ReadLine();

            if (UserInput == "1") {

            Entry newEntry1 = new Entry();
            newEntry1.runGenerator();

            }

            else if (UserInput == "2") {
                //Display all text on file
                Display DisplayAll = new Display();
                DisplayAll.DisplayAll();
            }

            else if (UserInput == "3") {
                //Save current version of txt file to computer
                Console.Write("Enter a file name to load: ");
                string userFile = Console.ReadLine();


                string filename = "tempList.txt";

                string[] lines = System.IO.File.ReadAllLines(userFile);

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (var item in lines)
                    {
                        outputFile.WriteLine(item);
                    }

                }
                Console.WriteLine();
            }
            

            else if (UserInput == "4") {
                //Save current version of txt file to computer
                Console.Write("Enter a file name: ");
                string userFile = Console.ReadLine();


                string filename = "tempList.txt";

                string[] lines = System.IO.File.ReadAllLines(filename);

                using (StreamWriter outputFile = new StreamWriter(userFile))
                {
                    foreach (var item in lines)
                    {
                        outputFile.WriteLine(item);
                    }

                }
                Console.WriteLine();
            }

            else if (UserInput == "5") {
                string filename = "tempList.txt";
                File.Delete(filename);
                //Closes down the program
            }

            else if (UserInput == "6") {
            Console.WriteLine();
            Console.WriteLine("Write: Allows you to write an entery while also giving a promtp to help write. Press ENTER to end.");
            Console.WriteLine("Display: Displays all enteris from the loaded file. If there is no file loaded then will display all current entries.");
            Console.WriteLine("Load: Allows you to load a txt file from your computer to write in or read from.");
            Console.WriteLine("Save: Enter a file name to save to or make a new file.");
            Console.WriteLine("End Program: Shuts the program down.");
            Console.WriteLine("Options: Allows you to adjust various settings.");
            Console.WriteLine();
            }

            else if (UserInput == "7") {
                Console.WriteLine("Enable sugestion promts?(y/n) ");
                string userOptions = Console.ReadLine();
                if (userOptions == "y") {
                    Options.usePrompt = true;
                }
                else if (userOptions == "n") {
                    Options.usePrompt = false;
                }
                Console.WriteLine("Use the date with each entery?(y/n) ");
                userOptions = Console.ReadLine();
                if (userOptions == "y") {
                    Options.useDate = true;
                }
                else if (userOptions == "n") {
                    Options.useDate = false;
                }
                Console.WriteLine();
            }

            else {
                //Error message
                Console.WriteLine("ERROR: That is not a valid input.");
                Console.WriteLine();
            }
        }
    }
}
}