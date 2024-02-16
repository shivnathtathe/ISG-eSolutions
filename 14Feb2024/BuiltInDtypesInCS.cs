using System;

class Program
{
    static void Main()
    {
        // Boolean type
        bool isTrue = true;
        bool isFalse = false;

        // Integral types
        byte byteValue = 255; // 8-bit unsigned integer
        short shortValue = -32000; // 16-bit signed integer
        int intValue = 2147483647; // 32-bit signed integer
        long longValue = 9223372036854775807; // 64-bit signed integer

        // Floating-point types
        float floatValue = 3.14f; // 32-bit floating-point number
        double doubleValue = 3.141592653589793; // 64-bit floating-point number

        // String type
        string message = "Hello, world!";

        // Verbatim string literal
        string filePath = @"C:\Users\Username\Documents\"; // Verbatim string literal

        // Output
        Console.WriteLine($"Boolean: {isTrue}, {isFalse}");
        Console.WriteLine($"Integral: {byteValue}, {shortValue}, {intValue}, {longValue}");
        Console.WriteLine($"Floating-point: {floatValue}, {doubleValue}");
        Console.WriteLine($"String: {message}");
        Console.WriteLine($"Verbatim string literal: {filePath}");
    }
}
