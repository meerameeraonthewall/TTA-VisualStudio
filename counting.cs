using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first name.");
        string fname = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter last name.");
        string lname = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Welcome, " + fname + lname);
        Console.Read();

    }
}

