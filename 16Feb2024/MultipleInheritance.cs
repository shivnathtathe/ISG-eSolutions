using System;

public interface I1
{
    void Method1();
}

public interface I2
{
    void Method2();
}

public class A : I1
{
    public void Method1()
    {
        Console.WriteLine("Method1 implementation in class A");
    }
}

public class B : I2
{
    public void Method2()
    {
        Console.WriteLine("Method2 implementation in class B");
    }
}

public class C : I1, I2
{
    public void Method1()
    {
        Console.WriteLine("Method1 implementation in class C");
    }

    public void Method2()
    {
        Console.WriteLine("Method2 implementation in class C");
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        B b = new B();
        C c = new C();

        a.Method1();
        b.Method2();
        c.Method1();
        c.Method2();
    }
}
