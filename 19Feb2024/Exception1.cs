using System;

class Program
{
    static void Main(string[] args)
    {
        int numerator = 10;
        int denominator = 0;

        try
        {
            int result = Divide(numerator, denominator);
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine(ex.Message);
        }
    }

    static int Divide(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Attempted to divide by zero.");
        }

        return numerator / denominator;
    }
}
