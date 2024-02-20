using System;

public enum Myenum
{
    Male,
    Female,
    Unknown
}

namespace myNamespace
{
    public class Enumclass
    {
        public static void Main()
        {
            Customer customer = new Customer()
            {
                Name = "Shiv",
                Gender = Myenum.Male.ToString()
            };

            customer.getinfo();
            Type t = typeof(Myenum);
            Console.WriteLine(t);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }

        public void getinfo()
        {
            Console.WriteLine("Name is = {0} and Gender is = {1}", this.Name, this.Gender);
        }
    }
}
