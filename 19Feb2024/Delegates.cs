using System;

public delegate void PrintMessage(string message);

public class MessagePrinter
{
    public void Print(string message)
    {
        Console.WriteLine("Message: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MessagePrinter printer = new MessagePrinter();

        PrintMessage messageDelegate = printer.Print;
        messageDelegate("Hello, world!");
    }
}
