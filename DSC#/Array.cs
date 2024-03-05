using System;

namespace Array
{
    class ArrayHere
    {
        public static void Main()
        {

            int[] array = new int[20];

            array[0] = 10;
            array[1] = 11;
            array[2] = 12;
            array[3] = 13;
            array[4] = 14;
            array[5] = 15;
            array[6] = 16;
            array[7] = 17;
            foreach (int x in array)
            {
                Console.Write(x);
            }
            int[] numbers = { 5, 2, 7, 1, 3 };

            // Length
            int length = numbers.Length;
            Console.WriteLine("Length: " + length);

            // Clear
            Array.Clear(numbers, 0, numbers.Length);
            Console.WriteLine("Cleared Array: " + string.Join(", ", numbers));

            // CopyTo
            int[] destination = new int[5];
            Array.Copy(numbers, destination, numbers.Length);
            Console.WriteLine("Copied Array: " + string.Join(", ", destination));

            // IndexOf
            int index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3: " + index);

            // Sort
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));

            // Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));


        }
    }
}