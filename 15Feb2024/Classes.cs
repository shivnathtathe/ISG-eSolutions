using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create objects of Employee class
        Employee shiv = new Employee();
        shiv.Name = "Shiv";
        shiv.Age = 30;
        shiv.Department = "HR";

        Employee tathe = new Employee();
        tathe.Name = "Tathe";
        tathe.Age = 25;
        tathe.Department = "IT";

        // Display employee details
        Console.WriteLine("Employee Shiv details:");
        shiv.DisplayEmployeeDetails();

        Console.WriteLine("\nEmployee Tathe details:");
        tathe.DisplayEmployeeDetails();
    }
}
