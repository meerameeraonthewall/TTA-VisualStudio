using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age? Please enter an integer.");
        int age = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI? Please enter true or false.");
        bool dui = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many speeding tickets do you have? Please enter an integer.");
        int tickets = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(age > 15 && dui == false && tickets < 3);
        Console.Read();
            

    }
}

