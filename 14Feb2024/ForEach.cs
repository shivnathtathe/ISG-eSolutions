using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Using for loop:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
        }

        Console.WriteLine("\nUsing foreach loop:");
        foreach (int num in numbers)
        {
            Console.WriteLine($"Element: {num}");
        }
    }
}
