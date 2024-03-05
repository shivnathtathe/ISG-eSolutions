using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();

        
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

       
        numbers.Remove(20); 
        numbers.RemoveAt(0);

        Console.WriteLine("Elements in the list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
