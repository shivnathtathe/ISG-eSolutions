using System;

public class OuterClass
{
    // Public inner class
    public class InnerClass
    {
        public void InnerMethod()
        {
            Console.WriteLine("Inner method called");
        }
    }

    // Private inner class
    private class PrivateInnerClass
    {
        public void PrivateInnerMethod()
        {
            Console.WriteLine("Private inner method called");
        }
    }

    public void OuterMethod()
    {
        InnerClass inner = new InnerClass();
        inner.InnerMethod();

        PrivateInnerClass privateInner = new PrivateInnerClass();
        privateInner.PrivateInnerMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        OuterClass outer = new OuterClass();
        outer.OuterMethod();
    }
}
