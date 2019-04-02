using System;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            int result;

            Console.WriteLine("Please enter an integer.");
            int val1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter a second integer, or press ENTER to use only the first integer.");
            Object intermediate = Console.ReadLine();

            try
            {
                int val2 = Convert.ToInt16(intermediate);
                result = Class1.Func1(val1, val2);
            }

            catch (FormatException)
            {
                result = Class1.Func1(val1);
            }

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
