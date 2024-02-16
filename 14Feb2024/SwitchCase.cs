using System;

class Program
{
    static void Main()
    {
        int choice = 2;
        int coffeeCount = 0;

        switch (choice)
        {
            case 1:
                coffeeCount += 1;
                Console.WriteLine("Added 1 coffee.");
                break;
            case 2:
                coffeeCount += 2;
                Console.WriteLine("Added 2 coffees.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine($"Total coffee count: {coffeeCount}");
    }
}
