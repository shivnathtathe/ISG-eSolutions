using System;
using System.Reflection;

public class MyClass
{
    public int MyProperty { get; set; }
    public void MyMethod()
    {
        Console.WriteLine("MyMethod is called");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get the type of MyClass using reflection
        Type myType = typeof(MyClass);

        // Get all properties of MyClass
        PropertyInfo[] properties = myType.GetProperties();
        Console.WriteLine("Properties of MyClass:");
        foreach (var property in properties)
        {
            Console.WriteLine($"Name: {property.Name}, Type: {property.PropertyType}");
        }

        // Get all methods of MyClass
        MethodInfo[] methods = myType.GetMethods();
        Console.WriteLine("\nMethods of MyClass:");
        foreach (var method in methods)
        {
            Console.WriteLine($"Name: {method.Name}, Return Type: {method.ReturnType}");
        }

        // Create an instance of MyClass
        MyClass myObject = new MyClass();
        myObject.MyProperty = 10;

        // Accessing properties using reflection
        PropertyInfo propertyInfo = myType.GetProperty("MyProperty");
        int propertyValue = (int)propertyInfo.GetValue(myObject);
        Console.WriteLine($"\nValue of MyProperty: {propertyValue}");

        // Accessing methods using reflection
        MethodInfo methodInfo = myType.GetMethod("MyMethod");
        methodInfo.Invoke(myObject, null);
    }
}
