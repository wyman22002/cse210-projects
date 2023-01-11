using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int userNum = 0;
        int sum = 0;
        int totalOfNumbers = 0;
        int largestNum = 0;

        do {
            Console.Write("Enter a Number: ");
            string userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            numbers.Add(userNum);
        } while (userNum != 0);

        foreach (int num in numbers)
        {
            sum += num;
            totalOfNumbers += 1;
            if (num > largestNum) {
                largestNum = num;
            }
        }

        int average = sum / totalOfNumbers;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}