using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer.");
        int numb =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number multiplied by 50 is " + (numb * 50));
        Console.Read();

    }
}
