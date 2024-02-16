using System;
class Program
{
    static void Main()
    {
        int? nullableInt = null;
        int regularInt = 10;
        
        // Arithmetic operators
        int sum = regularInt + (nullableInt ?? 0);
        int difference = regularInt - (nullableInt ?? 0);
        int product = regularInt * (nullableInt ?? 1);
        int quotient = regularInt / (nullableInt ?? 1);
        int modulus = regularInt % (nullableInt ?? 1);

        // Comparison operators
        bool isEqual = regularInt == (nullableInt ?? 0);
        bool isNotEqual = regularInt != (nullableInt ?? 0);
        bool isGreaterThan = regularInt > (nullableInt ?? 0);
        bool isLessThan = regularInt < (nullableInt ?? 0);
        bool isGreaterThanOrEqual = regularInt >= (nullableInt ?? 0);
        bool isLessThanOrEqual = regularInt <= (nullableInt ?? 0);

        // Logical operators
        bool logicalAnd = true && (nullableInt != null);
        bool logicalOr = true || (nullableInt != null);
        bool logicalNot = !(nullableInt == null);

        // Null coalescing operator
        int result = nullableInt ?? regularInt;
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Modulus: {modulus}");
        Console.WriteLine($"Is Equal: {isEqual}");
        Console.WriteLine($"Is Not Equal: {isNotEqual}");
        Console.WriteLine($"Is Greater Than: {isGreaterThan}");
        Console.WriteLine($"Is Less Than: {isLessThan}");
        Console.WriteLine($"Is Greater Than Or Equal: {isGreaterThanOrEqual}");
        Console.WriteLine($"Is Less Than Or Equal: {isLessThanOrEqual}");
        Console.WriteLine($"Logical AND: {logicalAnd}");
        Console.WriteLine($"Logical OR: {logicalOr}");
        Console.WriteLine($"Logical NOT: {logicalNot}");
        Console.WriteLine($"Result: {result}");
    }
}
