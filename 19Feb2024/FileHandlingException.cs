using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "xyz";

        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found:");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unhandled exception occurred:");
            Console.WriteLine(ex.Message);
        }
    }
}
