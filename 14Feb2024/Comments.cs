using System;

class Program
{
    static void Main()
    {
        // Single-line comment.
        Console.WriteLine("Single-line comment");

        /*
            Multi-line comments.
        */
        Console.WriteLine("Multi-line comment");

        // XML comment
        /// <summary>
        /// </summary>
        static void MyMethod()
        {
            Console.WriteLine("XML comment");
        }

        MyMethod();
    }
}
