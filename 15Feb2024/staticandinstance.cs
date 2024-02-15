using System;

// Static class
static class MathUtility
{
    // Static method to add two numbers
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// Instance class
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Instance method to display person details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using the static class and method
        int sum = MathUtility.Add(5, 3);
        Console.WriteLine("Sum: " + sum);

        // Using the instance class and method
        Person person1 = new Person("John", 30);
        person1.DisplayDetails();

        Person person2 = new Person("Alice", 25);
        person2.DisplayDetails();
    }
}
