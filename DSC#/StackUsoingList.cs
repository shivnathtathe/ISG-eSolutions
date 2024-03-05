using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> stack = new List<int>();

        stack.Add(1);
        stack.Add(2);
        stack.Add(3);

        while (stack.Count > 0)
        {
            int lastIndex = stack.Count - 1;
            int top = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            Console.WriteLine(top);
        }
    }
}
