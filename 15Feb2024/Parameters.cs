using System;

class Program
{
    static void Main(string[] args)
    {
        // Value parameter
        int a = 10;
        int b = 20;
        int sum = Add(a, b);
        Console.WriteLine($"Sum of {a} and {b} is: {sum}");

        // Reference parameter
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original array:");
        PrintArray(numbers);
        MultiplyArray(ref numbers, 2);
        Console.WriteLine("Array after multiplication:");
        PrintArray(numbers);

        // Out parameter
        int quotient;
        int remainder;
        Divide(10, 3, out quotient, out remainder);
        Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
    }

    // Value parameters
    static int Add(int x, int y)
    {
        return x + y;
    }

    // Reference parameter
    static void MultiplyArray(ref int[] arr, int factor)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= factor;
        }
    }

    // Out parameters
    static void Divide(int dividend, int divisor, out int quotient, out int remainder)
    {
        quotient = dividend / divisor;
        remainder = dividend % divisor;
    }

    // Print array elements
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
