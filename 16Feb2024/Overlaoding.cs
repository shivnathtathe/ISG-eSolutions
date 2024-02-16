class Add
{
    public int method1(int num1, int num2)
    {
        return num1 + num2;
    }

    public int method1(int num1)
    {
        return num1;
    }
}

public class Test
{
    public static void Main()
    {
        Add a = new Add();
        Console.WriteLine(a.method1(1, 2));
        Console.WriteLine(a.method1(10));

    }
}