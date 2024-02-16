using System;

public struct Person
{
    public string Name { get; set; }
}

class Test
{
    public static void Main()
    {
        Person person;
        person.Name = "Shiv Tathe";
        Console.WriteLine("Name: " + person.Name);
    }
}
