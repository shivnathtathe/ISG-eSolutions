using System;

class Program
{
    static void Main()
    {
        int number = 10;

        if (number > 0)
        {
            Console.WriteLine("Number is positive");
        }


        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }

        if (number < 5)
        {
            Console.WriteLine("Number is less than 5");
        }
        else if (number >= 5 && number <= 10)
        {
            Console.WriteLine("Number is between 5 and 10");
        }
        else
        {
            Console.WriteLine("Number is greater than 10");
        }

        string result = (number > 0) ? "Number is positive" : "Number is non-positive";
        Console.WriteLine(result);
           }
}