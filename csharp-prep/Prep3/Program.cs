using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(0,100);
        int userGuess = 0;
        do
        {
            Console.Write("Guess the magic number: ");
            string input = Console.ReadLine();
            userGuess = int.Parse(input);

            if (userGuess > magicNum) {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNum) {
                Console.WriteLine("Higher");
            }
        } while (userGuess != magicNum);

        Console.WriteLine("YOU WIN!!");
    }
}