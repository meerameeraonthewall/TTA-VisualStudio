using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] greetings = { "hello", "bonjour", "guten Tag", "hola", "ni hao", "namaste", "ciao", "konnichiwa" };
        Console.WriteLine("Please enter an Index integer between 0 and 7.");
        int index = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(greetings[index]);

        int[] nums = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        Console.WriteLine("Please enter an integer.");
        int index2 = Convert.ToInt16(Console.ReadLine());

        if (index2<11)
        {
            Console.WriteLine("Your number is " + nums[index2]);
        }
        else
        {
            Console.WriteLine("That value is out of index range.");
        }

        List<string> content = new List<string>();
        content.Add("goodbye");
        content.Add("au revoir");
        content.Add("tschuss");
        content.Add("adios");
        content.Add("zaijian");
        content.Add("alvida");
        content.Add("addio");
        content.Add("sayonara");

        Console.WriteLine("Please enter an Index integer between 0 and 7.");
        int index3 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(content[index3]);

        Console.Read();
    }
}

