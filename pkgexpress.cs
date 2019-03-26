using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("What is your package weight? Please enter an integer.");
        int weight = Convert.ToInt16(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            Console.Read();
        }


        else
        {
            Console.WriteLine("What is your package width? Please enter an integer.");
            int width = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is your package length? Please enter an integer.");
            int length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is your package height? Please enter an integer.");
            int height = Convert.ToInt16(Console.ReadLine());

            if (width + height + length > 50)
            { 
                Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.Read();
             }


            else
            {
            int quote = ((width + height + length) * weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.Read();
             }

        }
    }
}

