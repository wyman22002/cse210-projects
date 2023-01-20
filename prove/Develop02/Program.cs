using System;
using System.IO; 

class Program
{

    
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
            }

            else if (UserInput == "5") {
                Console.WriteLine("Run 5");
                string filename = "tempList.txt";
                File.Delete(filename);
                //Closes down the program
            }

            else {
                //Error message
                Console.WriteLine("That is not a valid input.");
                Console.WriteLine();
            }
        }


    }
}