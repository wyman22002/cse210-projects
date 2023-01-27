using System;

public class Display 
{
    public Display(){

    }
    public void DisplayAll() {

        string filename = "tempList.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        Console.WriteLine();
        foreach (var item in lines)
        {
            Console.WriteLine(item);
        }
    }
    
}