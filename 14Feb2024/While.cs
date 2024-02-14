using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int count = 0;

        while (count < 10)
        {
            Console.Write($"Enter number {count + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                sum += number;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine($"Sum of the 10 numbers is: {sum}");
    }
}
