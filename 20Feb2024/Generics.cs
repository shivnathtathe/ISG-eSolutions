    using System;
    public class GenericClass<T>
    {
        private T genericField;

        // Constructor initializing the generic field
        public GenericClass(T value)
        {
            genericField = value;
        }

        // A method that returns the value of the generic field
        public T GetValue()
        {
            return genericField;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of GenericClass with different types
            GenericClass<int> intObj = new GenericClass<int>(10);
            Console.WriteLine("Value of intObj: " + intObj.GetValue());

            GenericClass<string> stringObj = new GenericClass<string>("Hello, generics!");
            Console.WriteLine("Value of stringObj: " + stringObj.GetValue());

            GenericClass<double> doubleObj = new GenericClass<double>(3.14);
            Console.WriteLine("Value of doubleObj: " + doubleObj.GetValue());
        }
    }
