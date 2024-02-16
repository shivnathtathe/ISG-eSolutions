using System;

public interface IShape
{
    double Area();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 5;
        rectangle.Height = 4;

        Console.WriteLine("Rectangle Area: " + rectangle.Area());
    }
}
