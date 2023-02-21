using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "0";
        int userTime = 0;

        while(userChoice != "4"){

            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1") {
                Activity activity1 = new Activity(
                "Breathing Activity", 
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
                "Test for OutroMessage");
                
                activity1.DisplayIntroMessage();
                //activity1.DisplayExplanation();
                userTime = activity1.Length();
                activity1.DisplayOutroMessage();
            }
        }
    }
}