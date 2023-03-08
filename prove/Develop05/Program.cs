using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string fileName = "tempFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("0");
        }

        string UserChoice = "0";

        Console.Clear();

        while(UserChoice != "6"){
            string points = File.ReadLines(fileName).First();

            Console.WriteLine(points);
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goal");
            Console.WriteLine("    4. Load Goal");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quite");
            Console.Write("Select a choice from the menu: ");
            UserChoice = Console.ReadLine();
            
                if (UserChoice == "1"){
                    //Create a new goal
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("    1.Simple Goal");
                    Console.WriteLine("    2.Eternal Goal");
                    Console.WriteLine("    3.Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalChoice = Console.ReadLine();

                    if (goalChoice == "1"){
                        SimpleGoal goal1 = new SimpleGoal();
                        goal1.GoalCreation();
                    }
                    else if (goalChoice == "2"){
                        EternalGoal goal2 = new EternalGoal();
                        goal2.GoalCreation();
                    }
                    else if (goalChoice == "3"){
                        ChecklistGoal goal3 = new ChecklistGoal();
                        goal3.GoalCreation();
                    } 
                    else {
                        Console.WriteLine("---ERROR---");
                        Console.WriteLine("That is not a valid input.");
                        Thread.Sleep(1250);
                    }
                    Console.WriteLine();
                }
                else if (UserChoice == "2"){
                    //Displays all of the goals
                    DisplaySimple dis1 = new DisplaySimple();
                    dis1.DisplayGoal();
                    Console.WriteLine();
                }
                else if (UserChoice == "3"){
                    //Save the goals into a file
                    Console.Write("Enter a file name: ");
                    string userFile = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(fileName);

                    using (StreamWriter outputFile = new StreamWriter(userFile))
                    {
                        foreach (var item in lines)
                        {
                            outputFile.WriteLine(item);
                        }
                    }
                    Console.WriteLine();
                }
                else if (UserChoice == "4"){
                    //Load a file to read/write from/to
                    Console.Write("Enter a file name to load: ");
                    string userFile = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(userFile);

                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (var item in lines)
                        {
                            outputFile.WriteLine(item);
                        }
                    }
                    Console.WriteLine();
                }
                else if (UserChoice == "5"){
                    //Check off a goal

                }
                else if (UserChoice == "6"){
                    //End the program
                    File.Delete(fileName);

                }
                else {
                    Console.WriteLine("---ERROR---");
                    Console.WriteLine("That is not a valid input.");
                    Thread.Sleep(1250);
                }
        }   
    }   
}