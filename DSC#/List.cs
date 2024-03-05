using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> myStrings = new List<string>();

        myStrings.Add("Apple");
        myStrings.Add("Banana");
        myStrings.Add("Orange");

        Console.WriteLine("Elements in the list:");
        for (int i = 0; i < myStrings.Count; i++)
        {
            Console.WriteLine($"Index {i}: {myStrings[i]}");
        }

        myStrings.Remove("Banana");

        myStrings.Insert(1, "Grapes");

        Console.WriteLine("\nElements in the list after modifications:");
        foreach (string fruit in myStrings)
        {
            Console.WriteLine(fruit);
        }
    }
}
