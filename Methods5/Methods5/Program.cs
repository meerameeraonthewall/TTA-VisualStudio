using System;

namespace Methods5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            Console.WriteLine("Please enter an integer.");
            int val1 = Convert.ToInt16(Console.ReadLine());

            obj.Func1(val1, out val1);

            Console.WriteLine(val1);
            Console.Read();
        }
    }
}
