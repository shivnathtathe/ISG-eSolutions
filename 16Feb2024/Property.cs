using System;
class Customer 
{
    private int _id;
    private string _name;
    private string _email;

    public string Email
    {
        set { 
        this._email = value;
        }
        get { 
        
        return this._email;
        }
    }
    public int Id { get; set; }
    public string Name { get; set; }
}

class Test
{
    public static void Main()
    {
        Customer customer = new Customer();
        customer.Id = 1;
        customer.Email = "sptathe2001@gmail.com";
        customer.Name = "Shiv Tathe";
        Console.WriteLine("My Name is {0}",customer.Name);
        Console.WriteLine("My ID is  {0}" , customer.Id);
        Console.WriteLine("My Email is {0}" , customer.Email);
    }
}