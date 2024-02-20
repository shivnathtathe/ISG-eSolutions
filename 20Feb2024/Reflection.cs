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
        // Create an instance of MyClass
        MyClass myObject = new MyClass();
        myObject.MyProperty = 10;

        // Get the type of MyClass using reflection
        Type myType = typeof(MyClass);

        // Accessing properties using reflection
        PropertyInfo propertyInfo = myType.GetProperty("MyProperty");
        int propertyValue = (int)propertyInfo.GetValue(myObject);
        Console.WriteLine($"MyProperty value: {propertyValue}");

        // Accessing methods using reflection
        MethodInfo methodInfo = myType.GetMethod("MyMethod");
        methodInfo.Invoke(myObject, null);
    }
}
