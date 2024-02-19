public enum Gender
{
    Male,
    Female,
    Unknown
}

public class Student
{
    public string Name { get; set; }
    public Gender Gender { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Gender: {Gender}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student() { Name = "Shiv", Gender = Gender.Male };
        Student s2 = new Student() { Name = "Ganesh", Gender = Gender.Male };
        Student s3 = new Student() { Name = "Vidya", Gender = Gender.Female };
        Student s4 = new Student() { Name = "Sam", Gender = Gender.Unknown };

        s1.PrintDetails();
        s2.PrintDetails();
        s3.PrintDetails();
        s4.PrintDetails();
    }
}
