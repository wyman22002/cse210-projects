using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 2, 8));
        shapes.Add(new Circle("Green", 2));

        foreach(Shape shape in shapes) {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"Color:{color} Area:{area}.");
        }
    }
}