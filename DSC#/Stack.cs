using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        while (stack.Count > 0)
        {
            int top = stack.Pop();
            Console.WriteLine(top);
        }
    }
}
