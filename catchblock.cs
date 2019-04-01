using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> listy = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Enter an integer by which to divide.");
        int val = 0;

        try
        {
            val = Convert.ToInt16(Console.ReadLine());
        }

        catch (System.FormatException)
        {
            Console.WriteLine("Please enter an integer, not a string.");
            Console.Read();
            return;
        }

            foreach (double item in listy)
            {
                Console.WriteLine(item / val);
                System.Threading.Thread.Sleep(300);
            }

        Console.WriteLine("{EXIT CATCH BLOCK}");
        Console.Read();
    }
}
