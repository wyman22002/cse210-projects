using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("West Street 200", "Sunyvile", "CA", "U.S.A");
        string address = address1.GetAddress();
        Lectures lectures1 = new Lectures("How to ride a bike", "7/19/23", 
        "Tips for learning to ride with 1 wheel", "10:00 AM", address, "Edward Elric", 45);
        Console.WriteLine(lectures1.Standard());
        Console.WriteLine();
        Console.WriteLine("Lecture" + lectures1.Short());
        Console.WriteLine();
        Console.WriteLine(lectures1.LecturesFull());
        Console.WriteLine();

        Address address2 = new Address("Hamilton Dome", "Portland", "OR", "U.S.A");
        address = address2.GetAddress();
        Rescptions rescptions1 = new Rescptions("Meet with Mark Hamill", "5/4/23", 
        "Meet and Greet with actor Mark Hamill!", "2:00 PM", address, true, "hamiltondome@contact.com");
        Console.WriteLine(rescptions1.Standard());
        Console.WriteLine();
        Console.WriteLine("Rescption" + rescptions1.Short());
        Console.WriteLine();
        Console.WriteLine(rescptions1.RescptionsFull());
        Console.WriteLine();

        Address address3 = new Address("Clover Ampatheater", "Dayton", "OH", "U.S.A");
        address = address3.GetAddress();
        Outdoor outdoor1 = new Outdoor("Talent show", "6/30/23", 
        "Local talent show to show off what you've got.", "6:30 PM", address, "Partly Cloudy");
        Console.WriteLine(outdoor1.Standard());
        Console.WriteLine();
        Console.WriteLine("Outdoor" + outdoor1.Short());
        Console.WriteLine();
        Console.WriteLine(outdoor1.OutdoorFull());
        Console.WriteLine();
    }
}