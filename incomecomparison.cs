using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Enter hourly rate.");
        double rate1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter hours worked per week.");
        double hours1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Person 2");
        Console.WriteLine("Enter hourly rate.");
        double rate2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter hours worked per week.");
        double hours2 = Convert.ToDouble(Console.ReadLine());

        double sal1 = rate1 * hours1;
        double sal2 = rate2 * hours2;
        Console.WriteLine("Weekly salary of Person 1: " + sal1);
        Console.WriteLine("Weekly salary of Person 2: " + sal2);
        Console.WriteLine("Does Person 1 make more money than Person 2? " + (sal1 > sal2));
        Console.Read();

    }
}

