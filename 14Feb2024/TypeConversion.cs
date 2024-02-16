using System;

class Program
{
    static void Main()
    {
        // Type cast operator ()
        int intValue = 10;
        double doubleValue = (double)intValue;

        // Convert class
        string intString = "123";
        int convertedInt = Convert.ToInt32(intString);

        // Parse method
        string doubleString = "3.14";
        double parsedDouble = double.Parse(doubleString);

        // TryParse method
        string boolString = "True";
        bool parsedBool;
        bool success = bool.TryParse(boolString, out parsedBool);

        Console.WriteLine($"Type cast operator: {doubleValue}");
        Console.WriteLine($"Convert class: {convertedInt}");
        Console.WriteLine($"Parse method: {parsedDouble}");
        Console.WriteLine($"TryParse method success: {success}, parsed value: {parsedBool}");
    }
}
