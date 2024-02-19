using System;

public delegate void MathOperation(int x, int y);

public class Calculator
{
    public void Add(int x, int y)
    {
        Console.WriteLine($"Addition: {x} + {y} = {x + y}");
    }

    public void Subtract(int x, int y)
    {
        Console.WriteLine($"Subtraction: {x} - {y} = {x - y}");
    }

    public void Multiply(int x, int y)
    {
        Console.WriteLine($"Multiplication: {x} * {y} = {x * y}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        MathOperation operation = calculator.Add;
        operation += calculator.Subtract;
        operation += calculator.Multiply;

        operation(10, 5);
    }
}
