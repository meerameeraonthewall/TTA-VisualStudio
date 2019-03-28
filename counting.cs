using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer.");
        int num = Convert.ToInt16(Console.ReadLine());

        while (num >= 0)
        {
            Console.WriteLine(num);
            num --;
            System.Threading.Thread.Sleep(500);
        }

        Console.WriteLine("Count to ten!");
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
            System.Threading.Thread.Sleep(500);
        }
        while (i < 11);
        Console.Read();
    }
}

