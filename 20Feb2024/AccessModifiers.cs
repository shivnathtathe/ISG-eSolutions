using System;

// Public access modifier - accessible from anywhere
public class PublicClass
{
    public int publicField = 10;

    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");
    }
}

// Internal access modifier - accessible only within the same assembly
internal class InternalClass
{
    internal int internalField = 20;

    internal void InternalMethod()
    {
        Console.WriteLine("This is an internal method.");
    }
}

// Protected access modifier - accessible only within the class or derived classes
public class BaseClass
{
    protected int protectedField = 30;

    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
}

public class DerivedClass : BaseClass
{
    public void AccessProtectedField()
    {
        Console.WriteLine($"Accessing protected field from derived class: {protectedField}");
    }

    public void AccessProtectedMethod()
    {
        ProtectedMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Public class
        PublicClass publicObject = new PublicClass();
        Console.WriteLine($"Public field: {publicObject.publicField}");
        publicObject.PublicMethod();

        // Internal class
        InternalClass internalObject = new InternalClass();
        Console.WriteLine($"Internal field: {internalObject.internalField}");
        internalObject.InternalMethod();

        // Protected access
        DerivedClass derivedObject = new DerivedClass();
        derivedObject.AccessProtectedField();
        derivedObject.AccessProtectedMethod();
    }
}
