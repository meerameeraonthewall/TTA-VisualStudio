﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("What page number are you on?");
        byte page = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Do you need help with anything? Please answer true/false");
        bool help = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positives = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        byte hours = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.Read();
    }
}
