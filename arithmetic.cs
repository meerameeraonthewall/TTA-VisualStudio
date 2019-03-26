using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer.");
        int numb1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number multiplied by 50 is " + (numb1 * 50));
        Console.WriteLine("Enter an integer.");
        int numb2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number plus 25 is " + (numb2 + 25));
        Console.WriteLine("Enter an integer.");
        int numb3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number divided by 12.5 is " + (numb3 / 12.5));
        Console.WriteLine("Enter an integer.");
        int numb4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Is your number greater than 50? " + (numb4>50));
        Console.WriteLine("Enter an integer.");
        int numb5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The remainder after dividing your number by seven is " + (numb5 % 7));
        Console.Read();
    }
}

