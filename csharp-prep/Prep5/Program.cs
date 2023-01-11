using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the program!");
        }
        
        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptuserNumber() {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }

        static int SquareNumber(int number) {
            int numSquared = number * number;
            return numSquared;
        }

        static void DisplayResult(string name, int num) {
            Console.WriteLine($"{name}, the square of your number is {num}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptuserNumber();
        int squaredNumber = SquareNumber(favNumber);
        DisplayResult(name, squaredNumber);
    }
}