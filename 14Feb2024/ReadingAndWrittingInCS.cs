using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your email: ");
        string email = Console.ReadLine();

        Console.WriteLine("Your details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Email: " + email);
    }
}
