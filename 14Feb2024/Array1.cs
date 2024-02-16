using System;

class Program
{
    static void Main()
    {
        
        int[] arr = new int[5];

        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;


        Console.WriteLine("Elements of the array:");
        foreach (int element in arr)
        {
            Console.WriteLine(element);
        }
    }
}
