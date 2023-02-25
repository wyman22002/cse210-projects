using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "0";
        int userTime = 0;


        while(userChoice != "4"){

            //Added collor to the menue as part of execeding the requirments
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   1. Start breathing activity");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("   2. Start reflecting activity");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   3. Start listing activity");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("   4. Quit");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1") {
                BreathingActivity breathActivity1 = new BreathingActivity(
                "Breathing Activity", 
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                );
                
                breathActivity1.DisplayIntroMessage();
                userTime = breathActivity1.Length();
                Console.Clear();
                breathActivity1.BreathActivity(userTime);
                breathActivity1.DisplayOutroMessage();
            }

            else if (userChoice == "2") {
                ReflectionActivity reflectionActivity1 = new ReflectionActivity(
                "Reflection Activity", 
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                );

                reflectionActivity1.DisplayIntroMessage();
                userTime = reflectionActivity1.Length();
                Console.Clear();
                reflectionActivity1.DisplayPrompt();
                Console.WriteLine();
                reflectionActivity1.DisplayStatment(userTime);
                Console.WriteLine();
                reflectionActivity1.DisplayOutroMessage();
            }

            else if (userChoice == "3") {
                ListingActivity listingActivity1 = new ListingActivity(
                "Listing Activity", 
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                );

                listingActivity1.DisplayIntroMessage();
                userTime = listingActivity1.Length();
                listingActivity1.Listing(userTime);
                listingActivity1.DisplayOutroMessage();
            }

            else if (userChoice == "4") {

            }
            else {
                Console.WriteLine("--ERROR--");
                Console.WriteLine("That is not a valid input.");
                Thread.Sleep(3000);
            }
        }
    }
}